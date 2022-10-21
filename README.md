<h1 align="center"> Covid Visualizer </h1>
  
  <div align="center">

  [![GitHub release](https://img.shields.io/github/v/release/matiasvallejosdev/ar-covid-visualizer)](https://github.com/matiasvallejosdev/ar-covid-visualizer/releases)
  [![GitHub release (latest by date)](https://img.shields.io/github/release-date/matiasvallejosdev/ar-covid-visualizer?style=plastic)](https://github.com/matiasvallejosdev/ar-covid-visualizer/releases)
  [![GitHub top language](https://img.shields.io/github/languages/top/matiasvallejosdev/ar-covid-visualizer?color=1081c2)](https://github.com/matiasvallejosdev/ar-covid-visualizer/search?l=c%23)
  [![GitHub Watchers](https://img.shields.io/github/watchers/matiasvallejosdev/ar-covid-visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/ar-covid-visualizer/watchers)
  [![GitHub Repo stars](https://img.shields.io/github/stars/matiasvallejosdev/ar-covid-visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/ar-covid-visualizer/stargazers)
  [![GitHub Forks](https://img.shields.io/github/forks/matiasvallejosdev/ar-covid-visualizer?color=4cc51e)](https://github.com/matiasvallejosdev/ar-covid-visualizer/network/members)
  <br />
  [![Unity Badge](http://img.shields.io/badge/-Unity3D_2020.3.5f1-000?logo=unity&link=https://unity.com/)](https://unity.com/)
  [![made-for-VSCode](https://img.shields.io/badge/Made%20for-VSCode-1f425f.svg)](https://code.visualstudio.com/)
  </div>
  
  <p align="center"> <br />
This repository contains an interactive viewer of the covid-19 data in Argentina. Developed in Unity as an augmented reality experience. You can place a map and look according to each state. When you approach a state, you will be able to see more details about your current situation. <br /><br />
    <a href="https://youtu.be/Q-14FaPrD-A" target="_blank">View Demo in Youtube</a> <br />
      <p align="center">
      <a href="https://www.youtube.com/watch?v=Q-14FaPrD-A&ab_channel=MatiasA.Vallejos" rel="nofollow">
      <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Gif%20(1).gif?raw=true" alt="Demo Video" width="250">
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
  - [Useful Links](#useful-links)
- [Screenshoot](#screenshoot)
- [Data Source](#data-source)
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

![Diagram](https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/ArquitectureDiagram.jpg?raw=true)

It should be noted that a fundamental part is fulfilled by the observers who are granted in this case by the UniRx reactive library, which can access its documentation in the git repository and is open-source.

### Useful Links

[UniRx](https://assetstore.unity.com/packages/tools/integration/unirx-reactive-extensions-for-unity-17276)

[Arquitecture overview](https://www.youtube.com/watch?v=nvPjmSseOdY&ab_channel=Etermax)

## Screenshoot
Game Screenshoot on Android Device.
<p>
  <p>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Screenshoot%20(1).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Screenshoot%20(2).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Screenshoot%20(3).png?raw=true" width="200">
    </a>
  </p>
  <p>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Screenshoot%20(4).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Screenshoot%20(5).png?raw=true" width="200">
    </a>
    <a rel="nofollow">
    <img src="https://github.com/matiasvallejosdev/ar-covid-visualizer/blob/main/docs/Screenshoot%20(6).png?raw=true" width="200">
    </a>
  </p>
  
## Data Source

We are using the API from this project: https://github.com/ExpDev07/coronavirus-tracker-api and https://coronavirus-vaccines-api.herokuapp.com/v2/

It uses the data by Johns Hopkins University Center for Systems Science and Engineering (JHU CSSE).
The data is updated every hour.

## Contributing

* Contributions are what make the open source community such an amazing place to be learn, inspire, and create. Any contributions you make are greatly appreciated. <br /><br />
　1.　Fork the Project. <br />
　2.　Create your Feature Branch. <br />
　3.　Commit your Changes. <br />
　4.　Push to the Branch. <br />
　5.　Open a Pull Request. <br />

## Credits

- Main Developer: [Matias A. Vallejos](https://www.linkedin.com/in/matiasvallejos/)

## Thanks

_For more information about the project contact me! Do not hesitate to write me just do it!_
