using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountryBarDisplay : MonoBehaviour
{
    const float SPEED = 1f;
    Vector3 desiredScale;

    void Start() {
        desiredScale = transform.localScale;
    }

    void Update() {
        transform.localScale = Vector3.Lerp(transform.localScale, desiredScale, Time.deltaTime * SPEED);
    }

    public void SetScale(float scale) {
        desiredScale.y = scale;
    }
}
