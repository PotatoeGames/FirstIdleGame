﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//my includes
using UnityEngine.UI;

public class TestClick : MonoBehaviour
{
    public Text clickCounter;
    public float clicks;
    public float countPerClick;

	// Use this for initialization
	void Start ()
    {
		clickCounter.text = "Counter: " + clicks;
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void clicked ()
    {
        clicks += countPerClick;
		clickCounter.text = "Counter: " + clicks;
    }
}