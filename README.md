# Mannchuoy Yam

# Tic-Tac-Toe Project
Tic-Tac-Toe is a VR game in which a player plays against AI. The gameplay is working fine but not optimized yet. 

## Goal
The goal of the project is to optimize the game so it can run at 60 FPS on mobile phone (iphone 6s is used for testing).

## Versions
- Unity 2017.4.18f1
- GVR Unity SDK v1.170.0
- Xcode 10.1

### GVR SDK for Unity
- `GoogleVR` > `Demos` is not included.
- `GoogleVR` > `GVRVideoPlayer.unitypackage` is included.
- The `Max Reticle Distance` value for the `GvrReticlePointer` used in the scene is set to `20` instead of the default `10`.
- Scripts applicable to the course have been updated to reflect Unity's API change from `UnityEngine.VR` to `UnityEngine.XR`.

>**Note:** If for any reason you remove and re-import GVR SDK for Unity v1.170.0, make sure you accept any API update pop-up prompts triggered by Unity. Alternatively, you can manually run the API updater (Unity menu `Assets` > `Run API Updater...`) after the import has completed.


## Before Optimization
The game can run less than 60 PFS on iMac and around 28 to 40 on iphone6s. The frame rate are varies depending on 
where the camera looks at the scene. The lowest frame rate seen is when the camera look at the game board and the player
point one of the grids. 

Here is the statistics from Unity:
Batches: 109
Tris: 197k
Verts: 138K
SetPass calls: 85
Shadow casters: 40

## Optimization Procedure
Step 1
	Use the Unity profiler to see examine the bottle neck. The following steps is based on the profiler result.
Step 2
	Replace the model with low poly one and using Atlas texture
Step 3
	Turn off particle system
Step 4
	Set the all games object to static except moving objects, AI's head, X object, O Object, and the cross object. 
Step 5 
	Change all the lights from real time to bake mode
Step 6
	Turn off some lights to improve more performance
Step 7
	Remove empty Start and Update functions from the scripts

## After Optimization
Here is the statistics from Unity:
Batches: 76
Tris: 26k
Verts: 26K
SetPass calls: 65
Shadow casters: 7

## Conclusion
There is a big improvement in frame rate when changing from using high poly to low poly. There is also a big noticable performance when using particle system and not using it. There is not much to add the game when using the particle system particularly for this game in VR. It could make the player's eyes irritating. Therefore, there should be a consideration when using it. I decide to remove it due to better performance and better for the eyes. 