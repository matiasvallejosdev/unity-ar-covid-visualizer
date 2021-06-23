using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "New Gravity Command", menuName = "Console/Gravity Command")]
public class GravityCommand : ConsoleCommand
{
    public override bool Process(string[] args)
    {
        if(args.Length != 1) {return false;}
        if(!float.TryParse(args[0], out float value))
        {
            return false;
        }

        Debug.Log("Configuration game gravity: " + value);
        Physics.gravity = new Vector3(Physics.gravity.x, value, Physics.gravity.z);
        
        return true;
    }
}
