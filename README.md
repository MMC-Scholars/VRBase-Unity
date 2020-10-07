# VRBase-Unity
A Unity Virtual Reality library built for faster development.

## Table of Contents
1. [Installation](#installation)
2. [Contributions](#contributions)
3. [Code Formatting](#codeFormatting)
4. [Unity Troubleshooting](#unityTroubleshooting)

## Installation <a name="installation"></a>
Simply copy this repository into a folder within a Unity project. To keep files organized,
it is recommended to add this library in the directory `Assets/Scripts/VRBase`.

If the Unity project is version-controlled, you may want to consider adding this library as 
a `git submodule`:
```
git submodule add https://github.com/MMC-Scholars/VRBase-Unity.git Assets/Scripts/VRBase
git submodule init
```

## Contributions <a name="contributions"></a>

Contributions to this project must follow the conventions we use.

1. [Naming Conventions](#namingConventions)
2. [Naming Variables and Objects](#namingVariablesAndObjects)
3. [Code Formatting](#codeFormatting)

### Naming Conventions <a name="namingConventions"></a>

This project follows the camelcase naming convention when determining the names of 
all variables and functions. The exceptions to this rule are as follows:
- Class or Struct names should be in pascalcase (identical to camelcase except 
  the first letter is capitalized). Special classes such as interfaces or abstract 
  classes will use a single capital letter at the start of the class name to denote the 
  type of class (e.g. an interface would be named `IInterfaceName`)
- Member variables should use the prefix identifier `m_` to denote that it is a 
  member variable (e.g. a camera component would be named `m_cameraComponent`). 
  An exception to this rule is public member variables that are exposed to the 
  editor (e.g. a public mouse sensitivity `float` variable in `BaseController` can simply 
  be named `mouseSensitivity`)
- Constant names should be in all capital letters with underscores to separate words 
  (e.g. a constant string could be named `MY_STRING_CONSTANT`)

### Naming Variables and Objects <a name="namingVariablesAndObjects"></a>

The name of a variable should directly reflect its function and the type of the variable.
The name should be a combination of adjectives or nouns that give a clear picture of its
purpose. For example, an integer that counts the number of player deaths could be called
`playerDeathCount`. Note that the word `Count` indicates that the variable type must be a 
numerical type. Some common words to represent each type include:

- `int` - count, num
- `float` - axis, count, percent, scale
- `bool` - has, is, will
- `string` - id, identifier, name
- arrays - arr, list

Functions should be named using verbs, since each function is enacting an action. Similarly,
functions which return member variables or simple values should be named with `get`, and 
functions which alter member variables or values should be named with `set`. For example, a
function that gets the number of player deaths could be called `getPlayerDeathCount()`, and
a function that sets the active state of an object could be called 
`setIsObjectActive(bool isActive)`.

## Code Formatting <a name="codeFormatting"></a>

To keep our codebase consistently styled for maximum readability, we enforce strict code
formatting using [Omnisharp](http://www.omnisharp.net/).

**If your preferred editor is [Visual Studio Code](https://code.visualstudio.com/):**

  - install the `Omnisharp` extension to install Omnisharp. This can be done by opening VS Code, typing `CTRL-p`, then `ext install omnisharp`. You can also search and install the extension from the extension browser. The extension is usually named `C#`.
  - To format on save, edit the VS Code setting (`CTRL-SHIFT-p` and search for Open Settings (UI)) for `Format On Save` and set it to true. You will need to restart VS Code.

**If your preferred editor is [Visual Studio](https://visualstudio.microsoft.com/):**

Visual Studio comes out of the box with a predefined C# formatter. You can format each individual file with `CTRL-k CTRL-d`.

## Unity Troubleshooting <a name = "unityTroubleshooting"></a>
A list of issues we've encountered with Unity and some potential fixes.

1. [Failed to load window layout](#windowLayout)

### Failed to load window layout <a name = "windowLayout"></a>
This will have a different solution depending on if it affects one project or all projects.

If it affects one project:
	
Open FileExplorer and go to [project name]/Library. Delete CurrentLayout-default.dwlt and reopen the project from the Unity Hub. If the problem still occurs, you may need to follow the steps for when this error affects all projects.

If it affects all projects:

One of your files got corrupted. Uninstall all versions of Unity and then the Unity Hub. Go to File Explorer and search for %APPDATA%. That should take you to the AppData folder or one of its subfolders. In AppData, you should see 3 subfolders called Local, LocalLow, and Roaming. Go into each and delete any folders with Unity or UnityHub in the name, then do the same inside C:\Program Files. Now that you’ve exorcised the corrupted file, you can finally redownload the installer from https://store.unity.com/download?ref=personal and reinstall UnityHub and the current version of Unity.
