## Virtual Reality Practicum

## Goal:

The goal of this excercise is to put togehter and practice some of the concepts in Unity to create a simple VR environment. 

## Directions:

1. Download the GitHub repository
2. Open the scene **Practicum** located inside: *Assets/Practicum/Scenes/*
3. Delete Main Camera
4. Download SteamVR plugin from the [Unity asset store](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647)
5. Download VRTK [from GitHub](https://github.com/thestonefox/VRTK.git)
6. Add VRTK to your Unity project
7. In your scene **Practicum** setup the VRTK_SDKManager to run with (at least):
	* VR simulator
	* SteamVR 
8. Design an **outdoor enviroment** that includes 2 inviting spaces that can be visited by the user
Consideration for your environment design are (implement at least 4):
	* Skybox:
		- Change the color of the current skybox to something of your choice
		- Add a new procedural skybox
	* Play with lighting. Add intersting lights to your environment and modify their values.
		- 3 spot lights
		- 3 point lights
	* If you are using a terrain, populate it with trees or other elements
	* Create a physics based animation (using hinges or springs), so when the user collides with it, it moves.
	* Particle sytems if needed
9. Add navigation either by teleporting or 
10. Make at least one obbject grabbale (VRTK_Interactable Object)
11. Use some of the scripts provided in: *Assets/Practicum/Scripts*
12. Save the scene 
13. Commit changes to repository, remember to add a useful commit message(s). 
14. Push committed changes to github


---
**NOTE:** Feel free to use and modify any of the scripts provided, add new scripts, and assets to the enviornment.
