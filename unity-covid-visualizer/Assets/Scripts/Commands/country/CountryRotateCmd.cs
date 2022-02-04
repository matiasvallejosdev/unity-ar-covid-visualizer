using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;

namespace Commands
{
    public class CountryRotateCmd : ICommand
    {
        private GameObject anchor;
        private float rotateFactor;

        public CountryRotateCmd(GameObject anchor, float rotateFactor)
        {
            this.anchor = anchor;
            this.rotateFactor = rotateFactor;
        }

        public void Execute()
        {
            if(anchor == null)
                return;
            
            // Rotate country
            anchor.transform.RotateAround(anchor.transform.position, Vector3.up, rotateFactor);
        }
    }
}
