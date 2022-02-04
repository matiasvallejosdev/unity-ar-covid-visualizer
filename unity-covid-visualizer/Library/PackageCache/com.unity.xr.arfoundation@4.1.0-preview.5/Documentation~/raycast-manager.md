# AR Raycast Manager

The raycast manager is a type of [trackable manager](trackable-managers.md).

![AR Raycast Manager](images/ar-raycast-manager.png "AR tracked image manager")

The raycast manager serves two purposes:
1. Provides an API to perform single raycasts.
1. Allows you to create a persistent `ARRaycast`. An `ARRaycast` is updated automatically until you remove it. Conceptually, it is similar to repeating the same raycast query each frame, but platforms with direct support for this feature can provide better results.

## Adding and removing raycasts

To add or remove a persistent raycast, call `AddRaycast` or `RemoveRaycast` on the `ARRaycastManager` component from script code.
