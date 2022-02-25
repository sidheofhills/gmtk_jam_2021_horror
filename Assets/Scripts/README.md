# The guide to the scripts

- The core **bad** idea that glues all the problems together is that I've decided to use **ScriptableObjects** in a very wrong way. 

  At the beginning of the project I thought that having a script with all the game balance's variable in one place would be a good idea. That's how the **GameData** was born. Now it contains not only several public variables that meant to bear the role of global variables, but all the Event names so that I couldn't make a spelling mistake. And that's why this GameData is mandatorily referenced by most of the scripts.  

- The second ugly sibling of GameData is **AudioClips**, which contains all the audio that I use in the game. Its usefulness is also controversial. I wanted all the clips be in the one place and I wanted some clips such as lightBulbsFlickering group to be randomly selected. But I've made a single AudioPlayer for that and I didn't want to make another. So to make it work with arrays and without, I've decided to make all the clips into arrays. This was rather stupid of me.

I probably could write a book on what's wrong with the code in the game so I'll make it quick:

**Audio** folder has ***AudioPlayer*** that is used in times when the functionality of AudioSource is not enough. That is in ***AudioMainLevelBg.cs*** and a couple of locacly placed audio scripts where sound must be per object, not per scene.

**Candles** folder is responsible for ***litting up the candles during the game***.  Its when there're all candles are lit and the player is still alive the game is basicaly won.

**Cutscene** folder is needed, because I didn't want ***the cutscene*** to be started from the beginning. It has ***to be activated***.

**Data** folder is the ***mother of all the evil*** as you read above.

**Lights** folder contains ***a state machine with three states***. I really wanted the states only to call methods from ***SingleLight*** and not changing the values in it. But I'm not sure that the way I did it is SOLID-good..

**Managers** folder has an ***Event Manager*** and a simple ***InputController***, ***SceneManager*** and ***Timer***  - they are really basic and a bit naive.

**Monster** folder contains an ***ObjectPool system***, ***monster behavior classes*** derived from an abstract class, scripts that needs to be placed on each prefab of the monster like ***MonsterVisibility*** class, and some global scripts.

**Penta** folder is responsible for all that ***pentagrams*** are doing, ***including thier audio***. I should've made this element of the gameplay into state machine as well.

**UI** is mostly about ***buttons*** and ***triggers*** with UI. ***And*** some ***cool flickering effects*** you may see on the Title in the Main Menu and in the GameLose scene.

**Utilities** folder has scripts that I intended to use as an ***extentions***.

**Weapon** is almost like monster folder, because the core mechanics of the weapon is ***similar to monster's object pooling***, but this one is much more simpler.

