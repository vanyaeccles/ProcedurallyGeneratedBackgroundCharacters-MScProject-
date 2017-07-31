﻿using UnityEngine;
using System;

[Serializable]
public class AgentStateParameter : MonoBehaviour
{


    protected float normValue;

    //public bool isModifiable;
    //public bool randomizeStartValue;



    public float normalizedValue
    {
        get { return normValue; }
    }


    // constructor

    public AgentStateParameter()
    {
        normValue = 50.0f;
    }
    
}
