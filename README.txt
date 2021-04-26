Games and Artificial Intelligence Techniques
Assignment 1

Students:
Michael Dann (s3365362)
Jayden Ivanovic (s3331571)


========
 Report
========

Please refer to "Report.pdf" attached for our write up of the game.


==================
 Running the game
==================

We had issues getting the game to run on RMIT computers when the "Library"
folder was not included with the project. We have included it here, but as a
precaution please check that the "Menu" scene looks EXACTLY the same as the
attached image "CorrectMenuScreen.jpg". If there are compatibility issues then
you will see several other junk sprites laid over the screen. For this reason
we have also included a compiled executable, which are a certain will run
correctly (run "ToadallyAwesome.exe" from the "Exe" folder).

If the project does look OK within Unity, please run it from the "Menu" scene.


=====================
 Snake and fly demos
=====================

The game includes two scenes that are intended to show off certain features.
These are accessible from the main menu. "Snake Demo" shows off the predators'
"smart hunting" behaviour, while "Fly Demo" shows off the flies' obstacle
avoidance.

Please note:
- The snake demonstration is best played on NORMAL difficulty. The snakes have
  been configured to never give up chasing (unless the frog is underwater).
- For the fly demo, visual debugging can be seen by turning on "Gizmos", or
  alternatively by playing the game un-maximised.


================
 Path debugging
================

To see visual debugging for our two pathfinding algorithms (plain A* and A*
with jump point search), select the "Player" GameObject in the scene
"MainScene" and tick "Draw Debug" on the "AStar Targeter" script component. The
algorithm used can be toggled by changing the "Search Mode" property on this
script. Again, turn on "Gizmos" or play the game un-maximised to see the debug
info. Red squares represent blocked nodes, while blue squares represent nodes
that were evaluated the last time the algorithm was called. The green lines
show the resultant path. The time taken to calculate the path is output to the
console.
