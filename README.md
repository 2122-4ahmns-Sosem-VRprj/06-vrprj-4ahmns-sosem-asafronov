# HTL-VRProject with XRInteractionToolkit !Template!

### Project description: 
This project contains two minigames and a labyrinth to go through.

### Development platform: 
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit 1.0.0-pre.8, XR Plugin Management 4.2.1, Oculus XR Plugin 1.10.0.

## Software/Hardware Requirements: 
Oculus hardware requirements https://support.oculus.com/248749509016567/
You need a VR headset in this case an Oculus Rift/Quest/Quest2

Examples: https://github.com/Unity-Technologies/XR-Interaction-Toolkit-Examples

### Target platform: 
Oculus Rift/S; Quest/2

### Third party material and packages:

| Package Name | Package ID | Version |
|:---:|:---:|:---:|
| JetBrains Rider Editor | com.unity.ide.rider | 2.0.7 |
| Oculus XR Plugin | com.unity.xr.oculus | 1.10.0 |
| OpenXR Plugin | com.unity.xr.openxr | 1.2.8 |
| Test Framework | com.unity.test-framework | 1.1.31 |
| TextMeshPro | com.unity.textmeshpro | 3.0.6 |
| Timeline | com.unity.timeline | 1.4.8 |
| Unity UI | com.unity.ugui | 1.0.0 |
| Version Control | com.unity.collab-proxy | 1.9.0 |
| Visual Studio Code Editor | com.unity.ide.vscode | 1.2.5 |
| Visual Studio Editor | com.unity.ide.visualstudio | 2.0.15 |
| XR Interaction Toolkit | com.unity.xr.interaction.toolkit | 2.0.1 |
| XR Plugin Management | com.unity.xr.management | 4.2.1 |

All 3D-Modells are made in blender by me.

### The Maze

I remodelled the maze for better lightbaking and texture settings (UV-Mapping)

![SkizzeMaze](https://user-images.githubusercontent.com/28704310/159113247-e0cfe023-79fb-4ffd-b76f-342c55d93ef2.png)

![grafik](https://user-images.githubusercontent.com/72389349/168016851-d8fc3af3-63c3-479c-9a09-68ad80bde1d1.png)

The "Roehren-System". Since there is none in the asset store...

![grafik](https://user-images.githubusercontent.com/72389349/168017647-66eb9332-9de6-46ee-a4e4-dac6aa33d6dd.png)

## Development

### XR-Origin
I made my own player with continious movement and smooth locomotion.
The tutorial I worked with: https://www.youtube.com/watch?v=5ZBkEYUyBWQ&t=0
I also added the possibility to snap in two different directions.

![grafik](https://user-images.githubusercontent.com/72389349/168020930-8e4802d8-f676-42f0-9447-7fc348d42e75.png)

![grafik](https://user-images.githubusercontent.com/72389349/168021015-76a75e4d-004d-4054-b74d-d80b3c5c51bf.png)

### Roehrensystem
While developing the game, some new and better ideas came up and in the end I changed the "Roehren-System-logic" a little bit.
Instead of looking for pipes liying around in the maze, you look for tape with which you try to fix holes that are present inside of the pipes.

![grafik](https://user-images.githubusercontent.com/72389349/168020071-1332afb5-fe1f-432d-ba5b-86c0dc187f39.png)

The tape you fix the pipes with:

![grafik](https://user-images.githubusercontent.com/72389349/168020400-041c199e-8632-4f76-8d64-2abdf3c5ecac.png)

When you pick up the tape (which is a Pick Up interactable), you can bring the tape near a socket interactor which then deactivates the particle effect (gas) and activates again if the tape gets removed from the socket interactor.

![grafik](https://user-images.githubusercontent.com/72389349/168021320-4755ff19-d703-4b60-ab7a-264609d54ad7.png)

### Solution to the first minigame:
![Solution](https://user-images.githubusercontent.com/72389349/169349012-96bd0d97-3a3a-4297-a388-15c7f82e9838.png)


