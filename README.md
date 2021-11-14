<h1 align="center"> Covid Visualizer </h1>
  
  <div align="center">

  [![GitHub release (latest by date)](https://img.shields.io/github/v/release/matiasvallejosdev/AR-Covid-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive)
  [![GitHub top language](https://img.shields.io/github/languages/top/matiasvallejosdev/AR-Covid-Visualizer?color=1081c2)](https://github.com/matiasvallejosdev/AR-Covid-Interactive/search?l=c%23)
  [![GitHub Watchers](https://img.shields.io/github/watchers/matiasvallejosdev/AR-Covid-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive/watchers)
  [![GitHub Repo stars](https://img.shields.io/github/stars/matiasvallejosdev/AR-Covid-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive/stargazers)
  [![GitHub Forks](https://img.shields.io/github/forks/matiasvallejosdev/AR-Covid-Visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/AR-Covid-Interactive/network/members)
  <br />
  [![Unity Badge](http://img.shields.io/badge/-Unity3D_2020.3.5f1-000?logo=unity&link=https://unity.com/)](https://unity.com/)
  [![made-for-VSCode](https://img.shields.io/badge/Made%20for-VSCode-1f425f.svg)](https://code.visualstudio.com/)
  [![CC BY-SA 4.0][cc-by-sa-shield]][cc-by-sa]
  </div>
  
  <p align="center"> <br />
This repository contains a viewer of the covid 19 data developed in augmented reality using ARFoundation (Arkit - Arcore) in Unity. Its objective is the integration of an API to obtain the information and process it to display it in an interactive format. <br /><br />
    <a href="https://youtu.be/Q-14FaPrD-A" target="_blank">View Demo in Youtube</a> <br />
      <p align="center">
      <a href="https://youtu.be/Q-14FaPrD-A" rel="nofollow">
      <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Gif%20(1).gif?raw=true" alt="Demo Video" width="250">
    </a>
  </p>
    
  </p>
</p>

## Table of Contents

- [Table of Contents](#table-of-contents)
- [Requirements](#requirements)
- [Installation](#installation)
- [Arquitecture](#arquitecture)
  - [Introduction](#introduction)
  - [Diagram](#diagram)
  - [Prerequisites](#prerequisites)
  - [Useful Links](#useful-links)
- [Screenshoot](#screenshoot)
- [Contributing](#contributing)
- [License](#license)
- [Credits](#credits)
- [Thanks](#thanks)
  
## Requirements

* Unity3d 2020.1.5f1
* UniRx 7.1.0
* Universal Render Pipeline 10.4.0
* ARFoundation 4.0.12
* ARCore XR Plugin 4.0.12
* ARKit XR Plugin 4.0.12
* TextMeshPro 3.0.6
* Input System 1.0.2
  
## Installation
　1. Clone a repository or download it as zip.
```
    git clone https://github.com/matiasvallejosdev/ar-covid-visualizer
```
　2. Importing dependences<br />
```
　　You can use project requeriments to start!
```

## Arquitecture
### Introduction 
The architecture used is **MVVM** (model-view-view-model) adapted for unity.
### Diagram
This is a picture of the architecture and the execution flow.

![Diagram](https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/ArquitectureDiagram.jpg?raw=true)

It should be noted that a fundamental part is fulfilled by the observers who are granted in this case by the UniRx reactive library, which can access its documentation in the git repository and is open-source.
### Prerequisites

This example assume you have knowlege of Unity 3d, data oriented programming and reactive programing.

### Useful Links

[Download UniRx](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)

[Arquitecture overview](https://www.youtube.com/watch?v=nvPjmSseOdY&ab_channel=Etermax)

## Screenshoot
Game Screenshoot on Android Device.
<p>
  <p>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Screenshoot%20(1).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Screenshoot%20(2).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Screenshoot%20(3).png?raw=true" width="200">
    </a>
  </p>
  <p>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Screenshoot%20(4).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Screenshoot%20(5).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/Project.Docs/Images/Screenshoot%20(6).png?raw=true" width="200">
    </a>
  </p>

## Contributing

* Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated. <br /><br />
　1.　Fork the Project. <br />
　2.　Create your Feature Branch. <br />
　3.　Commit your Changes. <br />
　4.　Push to the Branch. <br />
　5.　Open a Pull Request. <br />

## License
This work is licensed under a
[Creative Commons Attribution-ShareAlike 4.0 International License][cc-by-sa].

[![CC BY-SA 4.0][cc-by-sa-image]][cc-by-sa]

[cc-by-sa]: http://creativecommons.org/licenses/by-sa/4.0/
[cc-by-sa-image]: https://licensebuttons.net/l/by-sa/4.0/88x31.png
[cc-by-sa-shield]: https://img.shields.io/badge/License-CC%20BY--SA%204.0-lightgrey.svg

## Credits

- Main Developer: [Matias A. Vallejos](https://www.linkedin.com/in/matiasvallejos/)

## Thanks

_For more information about the project contact me! Do not hesitate to write me just do it!_
