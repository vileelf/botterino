﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using System.Drawing;
using System.Web;

namespace Chatterino.Common
{
    
    public static class EmoteCache
    {
        private struct _emotes_cache {
            public string emotePath;
            public bool usedLastTime;
            [JsonIgnore]
            public Image emote;
        }

        private static ConcurrentDictionary<string, _emotes_cache> CachedEmotes =
            new ConcurrentDictionary<string, _emotes_cache>();

        public static Image GetEmote(string url) {
            _emotes_cache ecache;
            
            if (CachedEmotes.TryGetValue(url, out ecache)) {
                ecache.usedLastTime = true;
                if (ecache.emote == null && File.Exists(ecache.emotePath)) {
                    try {
                        ecache.emote = Image.FromFile(ecache.emotePath);
                    } catch (Exception e) {
                        GuiEngine.Current.log("emote faild to load " + ecache.emotePath + " " +e.ToString());
                    }
                }
                if (ecache.emote == null) {
                    //assume file doesnt exist. remove from the cache.
                    CachedEmotes.TryRemove(url, out ecache);
                }
                return ecache.emote;
            }
            return null;
        }
        
        public static bool AddEmote(string url, Image emote) {
            _emotes_cache ecache;
            if (CachedEmotes.TryGetValue(url, out ecache)) {
                return false;
            }
            ecache.usedLastTime = true;
            ecache.emotePath = Path.Combine(Util.GetUserDataPath(), "Cache", "Emotes", HttpUtility.UrlEncode(url));
            ecache.emote = emote;
            try {
                //save emote to a file
                if (File.Exists(ecache.emotePath)) {
                    File.Delete(ecache.emotePath);
                }
                bool animated = ImageAnimator.CanAnimate(emote);
                if (!animated) {
                    emote.Save(ecache.emotePath);
                }
                CachedEmotes.TryAdd(url, ecache);
            } catch (Exception e) {
                GuiEngine.Current.log("emote faild to save " + ecache.emotePath + " " +e.ToString());
            }
            return true;
        }
        
        public static void SaveEmoteList() {
            try {
                JsonSerializer serializer = new JsonSerializer();
                string emotesCache = Path.Combine(Util.GetUserDataPath(), "Cache", "emote_cache.json");
                using(StreamWriter stream = new StreamWriter(emotesCache)) {
                    using (JsonWriter writer = new JsonTextWriter(stream)) {
                        serializer.Serialize(writer, CachedEmotes);
                        writer.Close();
                    }
                    stream.Close();
                }
            } catch (Exception e) {
                GuiEngine.Current.log("error saving emote cache " + e.ToString());
            }
        }
        
        public static void init () {
            //load list of emotes from file and delete unused ones
            try {
                string dir = Path.Combine(Util.GetUserDataPath(), "Cache", "Emotes");
                Directory.CreateDirectory(dir);
                string emotesCache = Path.Combine(Util.GetUserDataPath(), "Cache", "emote_cache.json");
                var stream = File.OpenRead(emotesCache);
                var parser = new JsonParser();
                dynamic json = parser.Parse(stream);
                dynamic cachedemote;
                _emotes_cache ecache;
                
                foreach (var url in json.Keys) {
                    cachedemote = json[url];
                    ecache = new _emotes_cache();
                    ecache.usedLastTime = cachedemote["usedLastTime"];
                    ecache.emotePath = cachedemote["emotePath"];
                    if (ecache.usedLastTime) {
                        ecache.usedLastTime = false;
                        ecache.emote = null;
                        CachedEmotes.TryAdd(url, ecache);
                    } else {
                        //unused delete the cache
                        try {
                            if (File.Exists(ecache.emotePath)) {
                                File.Delete(ecache.emotePath);
                            }
                        } catch (Exception e) {
                            GuiEngine.Current.log("emote faild to delete " + ecache.emotePath + " " +e.ToString());
                        }
                    }
                }
                
                stream.Close();
            } catch (Exception e) {
                GuiEngine.Current.log("error loading emote cache " + e.ToString());
            }
        }
    }
}
