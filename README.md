# WhenFruitAttack
3D Fruit Ninja Cave Navigation Game

By Angelica Garcia and Joe Wileman

CAP 6121 Assignment 2 - Spring 2017

[![WhenFruitAttack Demo](images/thumbnail.png?raw=true)](https://www.youtube.com/watch?v=Qji-imwxFSE)

## Introduction

You are trapped in a cave full of nutritious fruit waiting to be eaten. But fruit are disgusting! You’d much rather have a delicious cake or a creamy chocolate-chip cookie. 
Armed with your katana and shurikens, you must brave the cave and all the mysteries that lay within...

## Game Scope

The player has a variety of abilities to traverse the cave, avoid nutritious fruit, and collect delicious goodies. The player’s main form of attack is the katana. 
The katana can chop, slash, and stab the fruit in the cave to prevent the player from taking damage. Similar to the classic Fruit Ninja, the fruit must not be allowed 
to touch the ground or player. If the player takes damage, cakes and cookies can be collected to restore health. The player can also parry the fruit to prevent taking damage. 
By jumping, gliding, and crouching the player can avoid being hit by fruit. A variety of commands are voice activated including star (shuriken), throw, 
fruit gods (make fruit moldy), chop, slash, stab, and fruit (to grab the fruit). Further into the cave are two bosses. Each boss is a giant fruit that chases the 
player when within reach. The bosses are a bit harder to kill but take damage from the katana, shurikens, and mold just like other fruit. All of the controls, 
including navigation and voice recognition, are inputted by the Microsoft Kinect. 

## Requirements

* 3D cave environment
* Travel through environment capability
* UI includes score and health
* Ninja Actions:
* Collect cookies and cakes to sustain energy
* Grappling hook used to select fruit and throw
* Finite set of throwing shurikens used to fight enemies
* Stab, slice, chop
* Parry to block incoming fruit attack
* Jump and duck under objects 
* Fly for brief periods of time 
* Call on the fruit gods with to make the fruit moldy, rendering it harmless for a short period of time. 
* Will have to fight various fruits
* Choose up to five different fruits with different abilities

## Extra Features

* Mini map
* Overhead halo locations
* Health bar and score system
* Intro screen
* The project was made using Unity’s collab feature (beta)

## Working

* Navigation: User can navigate through environment by leaning forward, back, or side to side in order to move forward, back, or side to side respectively. The user can also turn the camera left or right by swinging their right and left arms respectively making a turning gesture. 
* Speech: User can use speech in order to spawn shurikens and enable or disable gliding. User can also utilize speech as an alternative to gestures in order to call the fruit gods, chop, slash or stab. Speech is utilized to select a particular fruit, and throw it forward. 
* Gestures: User can use gestures in order to jump, duck, perry, chop, slash, stab, and call the fruit gods. Scene navigation is also accomplished through gestures as explained above.
* Game Logic: User can gain health by collecting a cookie or a cake. User looses health by being hit by a fruit, or the fruit hitting the ground. The user can increase their score by hitting the fruit with the katana or the shurikens. If the user is parrying, the user is not losing health. 
* Fruit Spawn: Fruit are randomly spawned at different intensities throughout the environment at certain waypoints. The apple slices in two when hit once and user but hit both remaining slices to receive score.  The banana peels when hit once and becomes completely peeled when hit again. User does not gain point until the banana is hit a third time. The strawberry is multiplied into four when hit once and the user must hit all duplicates to gain score. The pear only needs one hit to get points and the kiwi moves really fast.

## Improvements

During the demo we experienced some trigger issues with the randomly spawning fruit. We believe our latest changes might have affected our on trigger flags. 
The problem was resolved when the project was rebuilt after the demo.

## Limitations, Struggles, Lessons Learned

We had a difficult time with the original first person controller and ray casting as the controller moved around the scene. We learned that it wasn’t the 
controller rotating, it was only the camera rotating as the character moved. We learned that ray casting from the camera works better than from the first 
person controller. We also has a difficult time with trigger behaviors, unity is very picky about parent/children colliders and trigger options. We used the 
unity collab feature and at one point we lost some changes when we merged the project. We learned that there is a specific sequence to publish and update 
the project in order to preserve all changes. 

Looking back to some heuristics used, we took into consideration player physical exhaustion and ease of use. For example we allow the user to use both speech 
and gestures instead of only one or the other. Also instead of having the user jump or duck, the user only has to pick up their left leg and put it back down. 

## Future Work

* Here are a few ideas we had or couldn’t get to in time for the project:
* Add a portal from one side of the maze to the other
* Add cool light effects to giant fruit (liberate 4.1 darkness)
* Add extra sounds

## Division of Work

### Angelica’s Work
* Navigation heuristics
* The cave
* Waypoints
* Fruit randomizer
* Cookies and cake
* Health and damage
* Moldy fruit (call the fruit gods)
* Intro scene animation
* Giant fruit behavior

### Joe’s Work
* Navigation heuristics
* The cave
* Katana animation and sound
* Moldy fruit (call the fruit gods)
* Custom first person controller (similar to the standard Unity asset)
* Voice recognition
* Shuriken behavior
