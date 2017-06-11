using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//my includes
using UnityEngine.UI;

public class JTestClick : MonoBehaviour
{
	public int countPerClick;
	public PlayerStats Stats;
	private bool held; //is mouse held?
	private bool isRunning; //is score incrementing?
		
	public void OnPointerDown() //Mouse click down Function
	{
		held = true;
		if (isRunning == false)
			StartCoroutine (inc ());
		else
			CallInc ();
	}

	public void OnPointerUp() //Mouse Click let go Function
	{
		held = false;
	}

	public IEnumerator inc() //While Mouse click held down, increment score
	{
		isRunning = true;
		while (held) 
		{
			CallInc();
			yield return new WaitForSeconds (1); //change this to a variable that changes speed
		}
		isRunning = false;
	}

	private void CallInc() //Function called to inc score
	{
		if (Stats != null)
			Stats.IncDronePopulation (countPerClick);
	}
}
