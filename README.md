<h1 align="center"> Covid Interactive Visualizer </h1>
  
<div align="center">

[![GitHub release (latest by date)](https://img.shields.io/github/v/release/matiasvallejosdev/AR-Covid-Interactive-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer)
[![GitHub top language](https://img.shields.io/github/languages/top/matiasvallejosdev/AR-Covid-Interactive-Visualizer?color=1081c2)](https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/search?l=c%23)
[![GitHub Watchers](https://img.shields.io/github/watchers/matiasvallejosdev/AR-Covid-Interactive-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/watchers)
[![GitHub Repo stars](https://img.shields.io/github/stars/matiasvallejosdev/AR-Covid-Interactive-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/stargazers)
[![GitHub Forks](https://img.shields.io/github/forks/matiasvallejosdev/AR-Covid-Interactive-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/network/members)
<br />
[![Unity Badge](http://img.shields.io/badge/-Unity3D_2020.3.5f1-000?logo=unity&link=https://unity.com/)](https://unity.com/)
[![made-for-VSCode](https://img.shields.io/badge/Made%20for-VSCode-1f425f.svg)](https://code.visualstudio.com/)

</div>
  <p align="center"> <br />
Development of a mobile application to visualize covid19 data using AR Foundation (Arkit / Arcore). <br /> Integration with API Rest to obtain the data in real time. Integration of Universal Render Pipeline and Post-Processing graphics.
<br />The OOP and SOLID principles are highlighted, and a scalable MVVM architecture with the UniRx reactive library.<br /><br />
    <a href="https://youtu.be/BuaH3zmLtNs" target="_blank">View Demo in Youtube</a> <br />
 <p align="center">
  <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://s6.gifyu.com/images/ezgif.com-gif-makercc9e5a15b78ce54c.gif" alt="Demo Video" style="max-width:100%;">
  </a>
 </p>
    
  </p>
</p>

<br />

## Table of Contents

- [Table of Contents](#table-of-contents)
- [Requirements](#requirements)
- [Important links](#important-links)
  - [Lastet release](#lastet-release)
- [Arquitecture](#arquitecture)
  - [Introduction](#introduction)
  - [Diagram](#diagram)
  - [Prerequisites](#prerequisites)
  - [Useful Links](#useful-links)
- [Screenshoot](#screenshoot)
- [Release](#release)
- [Future Release](#future-release)
- [Trouble Shooting](#trouble-shooting)
- [Known issues](#known-issues)
- [Contributing](#contributing)
- [License](#license)
- [Credits](#credits)
- [Thanks](#thanks)
  
## Requirements

* Unity3d 2020.1.5f1
* Visual Studio Code 1.2.3
* UniRx 7.1.0
* Universal Render Pipeline 10.4.0
* ARFoundation 4.0.12
* ARCore XR Plugin 4.0.12
* ARKit XR Plugin 4.0.12
* TextMeshPro 3.0.6
* Input System 1.0.2
  
## Important links
### Lastet release 
[Download APK for android device]("")

## Arquitecture
### Introduction 
The architecture used is **MVVM** (model-view-view-model) adapted for unity.

The purpose of this architecture is to bring code reusability, simplicity, resilience and interdicipline cooperation to de game development process.

### Diagram
This is a picture of the architecture and the execution flow.

![Diagram](https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/ArquitectureDiagram.jpg?raw=true)

It should be noted that a fundamental part is fulfilled by the observers who are granted in this case by the UniRx reactive library, which can access its documentation in the git repository and is open-source.

### Prerequisites

This example assume you have knowlege of Unity 3d, data oriented programming and reactive programing.

### Useful Links

I use as tool Unirx library. [Download UniRx](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)

[More information about this arquitecture](https://www.youtube.com/watch?v=nvPjmSseOdY&ab_channel=Etermax)

## Screenshoot
Game Screenshoot on Android Device.

 <p align="center">
   <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/screenshoot_01.png?raw=true" alt="Demo Video" style="max-width:30%;">
  </a>
  <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/screenshoot_06.png?raw=true" alt="Demo Video" style="max-width:30%;">
  </a>
  <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/screenshoot_08.png?raw=true" alt="Demo Video" style="max-width:30%;">
  </a>
 </p>
  <p align="center">
   <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/screenshoot_12.png?raw=true" alt="Demo Video" style="max-width:30%;">
  </a>
  <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/screenshoot_13.png?raw=true" alt="Demo Video" style="max-width:30%;">
  </a>
  <a href="https://youtu.be/BuaH3zmLtNs" rel="nofollow">
  <img src="https://github.com/matiasvallejosdev/AR-Covid-Interactive-Visualizer/blob/main/Documentation/Images/screenshoot_05.png?raw=true" alt="Demo Video" style="max-width:30%;">
  </a>
 </p>

## Release
| Version | New Features | Date (AAAA-MM-dd) |
|:---:|---|:---:|
| v1.0.0 | [Initial features with only Argentina country]() | 2021.06.14 |


## Future Release
* New API for Argentina Provinces 
* World Data Interactive Visualizer



## Trouble Shooting
* If an error such as ""
<br />
　　example:
<br />

```
So far no errors
```
  <br />
　　solutions: 
  <br />

    .**


## Known issues

* The states CountryGateway.cs for Argentina be desactivated beacause doesn't have an valid API.


## Contributing

* Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated. <br /><br />
　1.　Fork the Project. <br />
　2.　Create your Feature Branch. <br />
　3.　Commit your Changes. <br />
　4.　Push to the Branch. <br />
　5.　Open a Pull Request. <br />

## License
* Open-Source

## Credits

- Main Developer: [Matias A. Vallejos](https://www.linkedin.com/in/matiasvallejos/)

## Thanks

_For more information about the project contact me! Do not hesitate to write me just do it!_