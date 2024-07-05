# Unity Battle Rabbits
Lua Rabbit skynet.  
# Status & Prerequisites
```
Unity version: 2019.4.28f1
Platforms    : 
client for Windows Android IOS;  
server only for Linux;
```
21.06.28: Decided not to use Unity's Entities, mainly because it is not easy to hot-update and not easy to use, so I still use Lua to implement another set, and also move the battle and scene-related logic to Lua, and make it a practical project.
20.03.08: Separate the server code to another git project
19.07.03: Preliminary implementation of automatic pathfinding to find NPC dialogue and monster killing two tasks:

19.07.31: Preliminary completion of backpack and GM system
19.08.13: Completed the resurrection process
19.08.28: Recently, I often test on mobile phones and optimize: camera operation, resource preloading, object pool, and use AutoLOD plug-in to generate two-level simple models for each scene node (in fact, many models can be replaced by a patch when they are at the farthest distance, that is, to make a billboard always facing the camera, but there are no art resources), and deleted a lot of trees with tens of thousands of triangles. Changed the light baking to use Distance ShadowMask, near real-time shadows and distant maps. It can run smoothly on my crappy phone for now.
19.09.07: Added buffs in the backend: fire, poison, freezing, stun, blood sucking, attribute deduction (defense, attack, etc.), silence. See BuffActions.lua for details. The front end currently only adds blood sucking and stun effects.
19.09.18: Added image format management tools for each platform, using different depths for images with different purposes, such as ETC2_RGBA8 for images in the ui folder on the Android platform, ETC_RGB8 for model images, etc., and the ASTC series format is used on iOS. See the unity editor menu for details: TextureFormatter
