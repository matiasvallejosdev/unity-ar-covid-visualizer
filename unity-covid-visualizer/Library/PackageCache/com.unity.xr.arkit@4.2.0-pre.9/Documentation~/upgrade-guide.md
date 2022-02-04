---
uid: arkit-upgrade-guide
---
# Upgrading to ARKit XR Plug-in version 4.2

To upgrade to ARKit XR Plug-in package version 4.2, you need to do the following:

- Remove uses of `NSError.isNull`.
- Use Unity 2020.3 or newer.

**Remove uses of `NSError.isNull`**

[NSError.isNull](xref:UnityEngine.XR.ARKit.NSError.isNull) has been deprecated. To determine whether an `NSError` is null, compare it to `null` using the `==` operator.

**Use Unity 2020.3 or newer**

This version of the package requires Unity 2020.3 or newer.
