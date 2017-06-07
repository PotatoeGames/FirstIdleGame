using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//my includes
using UnityEngine.UI;

public class JBuildingclick : MonoBehaviour 
{

	public Text clickCounter;
	public float clicks;
	public float countPerClick;

	void OnMouseDown()
	{
		clicks += countPerClick;
		clickCounter.text = "Counter: " + clicks;
	}

}
