using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//my includes
using UnityEngine.UI;

public class JTestClick : MonoBehaviour{

	public Text clickCounter;
	private int clicks;
	public int countPerClick;
	public PlayerStats Stats;
	public IEnumerator coroutine;

	void Start ()
	{
		coroutine = inc();

	}

	public void clicked ()
	{
		//if (Stats != null)
			//Stats.IncDronePopulation (countPerClick);
	}
		
	public void OnPointerDown() //OnMouseDown OnPointerDown
	{
		Debug.Log ("MouseDown");
		StartCoroutine (coroutine);
		//yield return new WaitForSeconds (1);
	}

	public void OnPointerUp() //OnMouseUp OnPointerUp
	{
		Debug.Log ("MouseUp");
		StopCoroutine (coroutine);
		if (Stats != null)
			Stats.IncDronePopulation (countPerClick);
	}

	public IEnumerator inc()
	{
		while (true) 
		{
			Debug.Log ("Inc");
			yield return new WaitForSeconds (1); //change this to a variable that changes speed
			if (Stats != null)
				Stats.IncDronePopulation (countPerClick);
		}
		//StartCoroutine (coroutine);
	}

	//create a click and hold function for generating drones slowly based onother variables for speed.
}
