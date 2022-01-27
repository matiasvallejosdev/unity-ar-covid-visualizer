---
uid: arkit-whats-new
---
# What's new in version 4.2

Summary of changes in ARCore XR Plug-in package version 4.2.

The main updates in this release include:

**Added**

- Added support for temporal smoothing of the environment depth image. When enabled and supported, this plugin now provides the environment depth image using [ARFrame.smoothedSceneDepth](https://developer.apple.com/documentation/arkit/arframe/3674209-smoothedscenedepth?language=objc) instead of [ARFrame.sceneDepth](https://developer.apple.com/documentation/arkit/arframe/3566299-scenedepth?language=objc).
- [ARKit reference objects](xref:UnityEngine.XR.ARKit.ARKitReferenceObjectEntry) now store their data in the entry asset, which allows them to be used in [AssetBundles](xref:UnityEngine.AssetBundle).

**Updated**

- Update [XR Plug-in Management](https://docs.unity3d.com/Packages/com.unity.xr.management@4.0) dependency to 4.0.
- Deprecated [NSError.isNull](xref:UnityEngine.XR.ARKit.NSError.isNull). To determine whether an `NSError` is null, compare it to `null` using the `==` operator.
- Static library was built with Xcode 12.4 (12D4e).

For a full list of changes and updates in this version, see the [ARKit XR Plug-in package changelog](xref:arkit-changelog).
