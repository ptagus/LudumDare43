﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    float x;
    int min;
    int hour = 5;
    TimeSpan ts;
    DateTime dt;
    public float timeBoost;
    public Text text;
	void Start ()
    {
        
	}
	
	void Update ()
    {
        x += Time.deltaTime * timeBoost;
        min = 60 - (int)x;
        if (min == 0)
        {
            hour--;
            x = 0;
        }
        text.text = "Hours: " + hour.ToString() + "Minutes: " + min.ToString();
	}
}

