using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARControlManager : Singlenton<ARControlManager>
{
    private ARControls arControls;
    public ARControls Controls
    {
        get{ return arControls; }
    }
    void OnEnable()
    {
        arControls = new ARControls();
        arControls.Enable();
    }
    void OnDisable()
    {
        arControls.Disable();
    }
}
