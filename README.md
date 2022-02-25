# Exorcist Practice
*Inspired by GMTK Jam 2021 "Joined together" theme*

**Exorcist Practice**  is my first made game and it was made on **Unity 2021.1.11**. As I had almost no experience in C# and Unity before that I've decided not to overwhelm myself with project design and UML tables. 
I wanted this game to be my experimental ground where I could practice new things I've learned about C# and Unity. 
I also certainly wanted to complete this project and upload it on itch.io, specificaly in **WebGL format** (which I did: [link to the game](https://sidheofhills.itch.io/exorcist-practice)).

**Completion of this project meant that it has to have:**

1. **A Main Menu**, as well as **Credits**: I wanted the game to start properly and to acknowlege all the people and resources that helped me making this game
    - so I worked with ***Unity UI/UX system***, ***Timeline***, ***Unity Events*** and ***Animation*** to make this work 

2. **Music and SFX**: working well and fit well with the theme, which was very important to me 
    - to achive that I had to learn more about ***AudioSpectrum*** (to have the ability to affect Graphics with Music) as well as ***AudioListener***, ***AudioSources*** and ***AudioClips***

3. **A narrative**: I wanted gaming experience to be consise, atmospheric and a bit intense (it is a spooky game after all). 
    - so I carefully watched after the details of which the game consists, like a little cutscene at the beguining, the lighting, the win-game/lose-game phrases and so on
 
4. **A _well enough_ code base** that supports narrative. This was the most fun part of the work for me to do, because I had to made several systems for the game to look and feel just the way I wanted, some of which are:
    - ***procedural animatiion*** of protective pentagram that switches its state. to do so I had to make a ***mathematical graph with several variables*** to feed it into Unity's AnimationCurve
    - ***state machine*** that switches ceiling lights on and off to make the scene spookier and monsters harder to kill
    - ***monster visibility system***, where the visibility of each monster's body depended on the state of the light they're under 
 
4. **The Art**, which works well with the narrative and music, making the atmosphere more well-tuned (this caused me some troubles though as I haven't used any Unity Lights to light the scene - it was all painted up in 2d)
    - to made it well enough I've experimented with ***Camera Settings***, ***PostProcessing***, ***URP*** and ***Shaders***

5. **A WebGL format** for people to be able to play the game in the browser easily 
    - to make the game run smoothely no matter how many monsters there're in the scene right at the moment and how fast the played kills them, I've made an ***ObjectPooling System***. It was **made from scratch** without using Unity's new feature of ObjectPooling, because at that time I didn't know about it
    - to optimise a little more (the game is a clicker that detects the position of the player's mouse and I had to use Colliders for it, which is Physics and *is* expensive) I've experimented with different types of ***Colliders***, ***RigidBody***'s options and such to make it cost less

6. **An Ending**. I really wanted to make a game that can be completed and, as my resources are not that big, therefore, short  
    - so I had to came up with a series of Events using ***Observer pattern*** linked with Time that lead to the Wining or Losing endings.

 
 
**All the things above are cool and teached me a lot about making a Unity projects, but, as it is only a study project, _it has lots of flaws_ too:**

  - My **main** but ineviteble in these circumstances **mistake** was ***the decision not to make any specific plans about this game***.
  I did the game on the go so there're lots of technical desisions that are not in any way could be considered a clean code. Though I tried to avoid coupling and high coherency, I surely didn't followed most of the SOLID principles well enough due to lack of experience. To my defence my goal was not to make an *ideal* game, but *to make* one, learn from its mistakes and move on to make the next one better. 
  - ***The narrative*** side of things ***might be too subtle*** at times. For example,  there're 4 things that tells player that the game is going to end soon: the music, the candles, the pentagrams and the lights at the end. But because of the intensity of the gameplay, sadly, most of the clues are not that visible to the player.
  - And, of course, I ***could've used more of the Unity's own features*** and not to invent the wheel all over again.



**So please, welcome under the hood of my game and I hope you won't lost there :)**
