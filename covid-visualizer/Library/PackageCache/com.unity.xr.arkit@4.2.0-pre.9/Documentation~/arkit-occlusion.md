---
uid: arkit-occlusion
---
# Occlusion

ARKit provides support for occlusion based on depth images it generates every frame.

There are three types of depth images that ARKit exposes through the provider's implementation of the [XROcclusionSubsystem](xref:UnityEngine.XR.ARSubsystems.XROcclusionSubsystem) implementation:

- **Environment depth**: distance from the device to any part of the environment in the camera field of view.
- **Human depth**: distance from the device to any part of a human recognized within the camera field of view.
- **Human stencil**: value that designates, for each pixel, whether that pixel is part of a recognized human.

## Requirements

Environment depth requires Xcode 12 or later, and it only works on iOS 14 devices with the LiDAR scanner, such as the new iPad Pro.

Human depth and human scencils requires Xcode 11 or later, and it only works on iOS 13+ devices with the A12 Bionic or higher.

