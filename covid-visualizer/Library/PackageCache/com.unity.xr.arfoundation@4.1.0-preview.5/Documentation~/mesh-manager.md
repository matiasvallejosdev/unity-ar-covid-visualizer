# AR mesh manager

Some platforms provide a meshing feature that generates a mesh based on scanned real-world geometry. The mesh manager enables and configures this functionality on supported platforms.

## Requirements

See documentation for your platform-specific package to confirm whether meshing is supported.

Additionally, not all devices provide support for all the features in the mesh manager. Some properties in the mesh manager are ignored on certain platforms. The platform-specific package documentation details which meshing features are available for each platform.

## Using meshing in a scene

To use meshing with AR Foundation, you need to add the [`ARMeshManager`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html) component to your scene.

![ARFoundation ARMeshManager component](images/arfoundation-mesh-manager.png)

### Mesh Prefab

You need to set the [`meshPrefab`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_meshPrefab) to a Prefab that is instantiated for each scanned mesh. The [`meshPrefab`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_meshPrefab) must contain at least a [`MeshFilter`](https://docs.unity3d.com/ScriptReference/MeshFilter.html) component.

If you want to render the scanned meshes, you need to add a [`MeshRenderer`](https://docs.unity3d.com/ScriptReference/MeshRenderer.html) component and a [`Material`](https://docs.unity3d.com/ScriptReference/Material.html) component to the [`meshPrefab`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_meshPrefab)'s GameObject.

If you want to have virtual content that interacts physically with the real-world scanned meshes, you will need to add [`MeshCollider`](https://docs.unity3d.com/ScriptReference/MeshCollider.html) component to the [`meshPrefab`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_meshPrefab)'s GameObject.

This image demonstrates a mesh Prefab configured with the required [`MeshFilter`](https://docs.unity3d.com/ScriptReference/MeshFilter.html) component, an optional [`MeshCollider`](https://docs.unity3d.com/ScriptReference/MeshCollider.html) component to allow for physics interactions, and optional [`MeshRenderer`](https://docs.unity3d.com/ScriptReference/MeshRenderer.html) and [`Material`](https://docs.unity3d.com/ScriptReference/Material.html) components to render the mesh.

![Mesh prefab example](images/arfoundation-mesh-prefab.png)

### Density

The [`density`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_density) property, in the range 0 to 1, specifies the amount of tessellation to perform on the generated mesh. A value of 0 results in the least amount tessellation, whereas a value of 1 produces the most tessellation.

Not all platforms support this feature.

### Normals

When the device is constructing the mesh geometry, it might calculate the vertex normals for the mesh. If you don't need the mesh vertex normals, disable [`normals`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_normals) to save on memory and CPU time.

Not all platforms support this feature.

### Tangents

When the device is constructing the mesh geometry, it might calculate the vertex tangents for the mesh. If you don't need the mesh vertex tangents, disable [`tangents`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_tangents) to save on memory and CPU time.

Not all platforms support this feature.

### Texture coordinates

When the device is constructing the mesh geometry, it might calculate the vertex texture coordinates for the mesh. If you don't need the mesh vertex texture coordinates, disable [`textureCoordinates`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_textureCoordinates) to save on memory and CPU time.

Not all platforms support this feature.

### Colors

When the device is constructing the mesh geometry, it might calculate the vertex colors for the mesh. If you don't need the mesh vertex colors, disable [`tangents`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_colors) to save on memory and CPU time.

Not all platforms support this feature.

### Concurrent Queue Size

To avoid blocking the main thread, the tasks of converting the device mesh into a Unity mesh and creating the physics collision mesh (if the [`meshPrefab`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_meshPrefab)'s GameObject contains a [`MeshCollider`](https://docs.unity3d.com/ScriptReference/MeshCollider.html) component) are moved into a job queue processed on a background thread. [`concurrentQueueSize`](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@4.1/api/UnityEngine.XR.ARFoundation.ARMeshManager.html#UnityEngine_XR_ARFoundation_ARMeshManager_concurrentQueueSize) specifies the number of meshes to be processed concurrently.
