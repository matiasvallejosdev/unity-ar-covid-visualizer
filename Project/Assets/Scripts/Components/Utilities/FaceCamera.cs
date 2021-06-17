using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    private Transform cam;
    Vector3 _targetAngle = Vector3.zero;

    void Start()
    {
        cam = Camera.main.transform;
    }

    void Update()
    {
        _targetAngle = transform.localEulerAngles;
        _targetAngle.z = 0;
        _targetAngle.x = 0;
        transform.localEulerAngles = _targetAngle;
        transform.LookAt(2 * transform.position - cam.position);
    }
}
