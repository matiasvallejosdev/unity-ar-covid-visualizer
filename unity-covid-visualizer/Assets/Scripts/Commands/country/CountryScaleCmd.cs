using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ViewModel;
using Lean.Touch;
using System;

namespace Commands
{
    public class CountryScaleCmd : ICommand
    {
        private GameObject anchor;
        private float scaleFactor;

        public CountryScaleCmd(GameObject anchor, float scaleFactor)
        {
            this.anchor = anchor;
            this.scaleFactor = scaleFactor;
        }

        public void Execute()
        {
            if(anchor == null)
                return;

            // Scale country
            anchor.transform.localScale += new Vector3(scaleFactor, scaleFactor, scaleFactor) * 1/6;
        }
    }
}
