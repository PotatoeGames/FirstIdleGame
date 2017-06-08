using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//my includes
using UnityEngine.UI;

public class JBuildingclick : MonoBehaviour 
{

	public Text clickCounter;
	private int clicks;
	public int countPerClick;
	public PlayerStats Stats;

	void OnMouseDown()
	{
		
		/*clicks += countPerClick;
		clickCounter.text = "Counter: " + clicks;*/
		Stats.IncPlayerEssence (countPerClick);
		//clicks = Stats.IncPlayerEssence () ;
		//clickCounter.text = "Essence: " + (Stats.GetPlayerEssence () + countPerClick);
	}

}
