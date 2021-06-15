using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;

public class BackgroundAnimationDisplay : MonoBehaviour
{
    const float SPEED = 0.2f;

    [Header("Scale for animation")]
    public Vector3 minScale, maxScale;

    private Vector3 _desiredScale;

    void Start()
    {
        _desiredScale = minScale;

        this.gameObject.AddComponent<ObservableUpdateTrigger>()
            .LateUpdateAsObservable()
            .SampleFrame(60*20)
            .Subscribe(x => OnLateUpdate())
            .AddTo(this);
    }

    void OnLateUpdate()
    {
        if(_desiredScale == minScale)
        {   
            _desiredScale = maxScale;
        }
        else
        {
            _desiredScale = minScale;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _desiredScale, Time.deltaTime * SPEED);
    }
}
