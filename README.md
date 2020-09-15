# VRBase-Unity
A Unity Virtual Reality library built for faster development.

## Table of Contents
1. [Installation](#installation)
2. [Unity TroubleShooting](#unityTroubleshooting)

## Installation <a name="installation"></a>
Simply copy this repository into a folder within a Unity project. To keep files organized,
it is recommended to add this library in the directory `Assets/Scripts/VRBase`.

If the Unity project is version-controlled, you may want to consider adding this library as 
a `git submodule`:
```
git submodule add https://github.com/MMC-Scholars/VRBase-Unity.git Assets/Scripts/VRBase
git submodule init
```

## Unity Troubleshooting <a name = "unityTroubleshooting"></a>
A list of issues we've encountered with Unity and some potential fixes.

1. [Failed to load window layout](#windowLayout)

### Failed to load window layout <a name = "windowLayout"></a>
This will have a different solution depending on if it affects one project or all projects.

If it affects one project:
	
Open FileExplorer and go to [project name]/Library. Delete CurrentLayout-default.dwlt and reopen the project from the Unity Hub. If the problem still occurs, you may need to follow the steps for when this error affects all projects.

If it affects all projects:

One of your files got corrupted. Uninstall all versions of Unity and then the Unity Hub. Go to File Explorer and search for %APPDATA%. That should take you to the AppData folder or one of its subfolders. In AppData, you should see 3 subfolders called Local, LocalLow, and Roaming. Go into each and delete any folders with Unity or UnityHub in the name, then do the same inside C:\Program Files. Now that you’ve exorcised the corrupted file, you can finally redownload the installer from https://store.unity.com/download?ref=personal and reinstall UnityHub and the current version of Unity.
