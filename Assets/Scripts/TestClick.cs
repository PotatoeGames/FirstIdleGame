using System.Collections;
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
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        clickCounter.text = "Counter: " + clicks;

	}

    public void clicked ()
    {
        clicks += countPerClick;

    }
}
