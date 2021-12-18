using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Components
{
    public class ARInputManager : Singlenton<ARInputManager>
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
}
