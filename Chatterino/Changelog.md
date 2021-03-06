﻿# changelog

## 1.9
- you can now tab complete using @ in commands
- added the ability to double click a word to select it
- fixed a bug causing you to lose your selection whenever there's a new message
- recombined reload channel and reload subemotes
- removed reload username list button
- subs and sub gifts are now added to the username tab complete list
- fixed issue causing some gifs to be too fast
- fixed issue preventing login for users with an _ in their name
- made gif emotes only animate when they are on screen
- changed the color of highlighted messages and removed them from the scrollbar
- search results now have highest priority for highlighting.
- made chatterino run much more efficiently
- updated message queue limit from 50 to 500 so you should get that ignored x messages less

## 1.8
- added follower count and streamer type to the user info popup 
- added the start of a search feature. Type in the chatbox and press ctrl+f to highlight any match. remove all text and press ctrl+f again to clear the search highlights
- added missing "hat" emotes to the hardcoded list. So things like SoSnowy should work
- added support for the highlighted messages feature from the new twitch points system
- updated to use the new bttv api so bttv emotes load again

## 1.7 hotfix
- fixed an issue preventing chatterino from finding the twitch channel id

## 1.7
- fully converted chatterino over to the twith api v5
- readded in the recent chat feature using third party api used by chatterino 2
- fixed the follow button to actually follow when clicked
- fixed the add a space for duplicate message feature

## 1.6 hotfix 2
- converted sub emotes and check if live over to twitch api v5.

## 1.6 hotfix
- added support for twitches new modified emotes
- disabled the check for updates functionality

## 1.6
- added tab highlighting for when a channel goes live and a channel setting for it
- added a new setting to disable the x buttons on tabs
- added a menu item to manually reload sub emotes and one to reload usernames
- fixed time displayed on sub messages
- added a new setting to ignore users using the twitch api vs chatterinos internal list

## 1.5
- added a new setting for username based highlighting
- now recognizes vip for fast messageing
- now properly respecting the setting for sending duplicate messages
- overloaded the reload channel emotes button to also reload your other emotes.

## 1.4
- added support for all bit emotes
- added support for all badges
- added support for custom cheer badges

## 1.3
- fixed the LSD bug (entire screen filling up with text that never gets cleared)
- changed access to the ffz api according to their changes

## 1.2.13
- updated to the .net framework 4.6.1
- fixed twitch emote images not loading
- added own implementation of ignored users instead of using the twitch api

## 1.2.12
- added optional ban and custom timeout buttons (sponsored by Wipz)

## 1.2.11
- fixed some arabic character crashing DirectWrite

## 1.2.10
- fixed an issue that caused chatterino to crash when it received invalid emote data from twitch

## 1.2.9
- fixed an issue with commands when sending duplicate messages

## 1.2.8
- added badges for 25000, 50000 and 75000 bits
- combined disconnecting and reconnecting message into one
- tweaked code a bit so it doesn't disconnect on my unis wifi as much

## 1.2.6
- added the twitch verified partner badge
- fixed chat being invisible when a global moderator is in chat
- fixed the moderator dropdown not showing

## 1.2.5
- added an option to prefere emotes over usernames when tab-completing
- fixed some username colors looking weird
- fixed streamlink quality options for streams that use "720p,480p,..." instead of "high,medium,..." as their quality options
- added custom arguments for streamlink
- fixed message limit not changing after being modded/unmodded
- made ctrl+enter send messages every 1.6 seconds if you are not mod

## 1.2.4
- added streamlink support (thanks to cranken1337)
- fixed an issue that caused bttv and ffz global emotes not to load for some users
- made username colors more vibrant
- changed colors for highlights, whispers and resubs

## 1.2.3
- fixed crash when closing splits
- fixed sending whispers from /whispers and /mentions
- fixed the very important typo in the settings

## 1.2.2
- added option for rainbow username colors
- made the "jump to bottom" more obvious
- fixed the reconnecting issue

## 1.2.1
- fixed text being copied twice

## 1.2
- fixed channel ffz emotes being tagged as "global"
- added ap/pm timestamp format
- added "new" cheer badges

## 1.1
- fixed window size resetting to 200x200 px on start

## 1.0.9
- fixed an issue preventing users from starting chatterino
- fixed the icon having a santa hat (when you restart your pc/clean icon cache)

## 1.0.8
- added /r which expands to /w <last user you whispered with>
- added support for ffz emote margins
- chatterino now uses the proper 2x and 4x emotes for ffz and bttv

## 1.0.7.1
- temporarily disabled SoSnowy again because it was causing lag

## 1.0.7
- fixed gif emotes with hats
- fixed hat emotes going over others in the emote list

## 1.0.6
- added support for the bttv christmas emotes (unfortunately SoSnowy does not work)

## 1.0.5
- added emote scaling
- added live indicator to splits
- added button in the user info popup to disable/enable highlights for certain users
- added option to show messages from ignored users if you are mod or broadcaster

- fixes the user info popup going over the screen workspace
- fixed shift + arrow keys not selecting text by characters
- fixed not parting channel when closing split
- fixed copying spaces after emojis

## 1.0.4
- fixed the messages appearing multiple times after switching accounts

## 1.0.3
- disabled hardware acceleration to take less performance when playing games
- now also shows outgoing whispers in chat when inline whispers are enabled
- some messages now don't highlight tabs anymore
- emote list now gets brought to front when you click the button again
- added option to reload channel emotes without restarting
- timeout messages are now bundled

## 1.0.2
- fixed the broken updater, sorry for the inconvenience NotLikeThis

## 1.0.1
- fixed cache being saved to the wrong directory causing bttv emotes not to show

## 1.0
- moved all the settings to %appdata%
- added support for multiple accounts (aka the feature nobody asked for)
- added login via fourtf.com for users that can't open a tcp port
- added /mentions tab (thanks to pajlada)
- fixed gif emotes with 0s frames crashing chatterino
- /whispers got updated

## 0.3.1.1
- added ffz event emotes

## 0.3.1.0
- added option to make the window top-most
- added loyalty subscriber badges
- fixed cheers split up in multiple words
- fixed backgrounds for custom mod badges
- fixed spacing when switching fonts
- improved mouse wheel scrolling very long messages

## 0.3.0.3
- fixed subscriber badges not showing up
- fixed timeout button in the user popup

## 0.3.0.2
- disabled mentioning with @ in commands

## 0.3
- added a slider for the mouse scroll speed
- added option for a manual reconnect
- added a popup when you click on a name
- added an option to ignore messages
- added a rightclick context menu for links
- added an option to mention users with an @
- added twitch prime badge
- fixed emotes in sub messages
- fixed the "gray thing"

## 0.2.6.4
- fixed sub badges not showing up

## 0.2.6.3
- fixed commands not updating when one is deleted

## 0.2.6.2
- added CTRL + 1-9 to select tabs
- added ALT + arrow keys to switch tabs
- added ignored users
- added a settings for the message length counter
- added an emote list popup
- added an option to change the hue of the theme
- changed preferences so all the changes are immediate and cancel reverts them
- fixed tabing localized names
- removed 1 hour emote cache
- tweaked global bad prevention

## 0.2.3
- added FFZ channel emotes
- added a message length counter
- added custom commands
- added a donation page https://streamtip.com/t/fourtf
- fixed timeouts not being displayed sometimes
- fixed ctrl + backspace not deleting a word for some users

## 0.2.2
- added x button to tabs
- add option to disable twitch emotes

## 0.2
- added tabs
- added 4 themes (white and light are still work-in-progress)
- added an option to seperate messages
- added a filter for emotes
- added cheerxxx emotes
- added arrow up/down for previous/next message
- added mouse text selection in the input box

## 0.1.5
- added ratelimiting for messages
- added the option to ignore highlights from certain users
- fixed emote/name tabbing when no completion is available
- fixed subs/resubs
- fixed timeouts not showing up
- fixed name links not being clickable
- fixed a graphics issue with extremely high windows
- esc now closes some dialogs

## 0.1.4
- added twitch bit cheer badges
- replaced irc library with my own irc implementation
- fixed some notices not showing up

## 0.1.3
- added setting to change font
- added custom highlight sounds
- added keyboard shortcuts: ctrl+x (cut text), ctrl+enter (send message without clearing the input), end + home (move to start / end of input)
- added direct write support
- improved performance of word-wrapping
- updated icon (thanks to SwordAkimbo)

## 0.1.2
- fixed text caret disappearing
- improved animated gif draw performance

## 0.1.1
- added a changelog viewer
- made text input prettier
