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
		if (Stats != null)
			Stats.IncPlayerEssence (countPerClick);
		/*clicks += countPerClick;
		clickCounter.text = "Counter: " + clicks;*/
		//clicks = Stats.IncPlayerEssence () ;
		//clickCounter.text = "Essence: " + (Stats.GetPlayerEssence () + countPerClick);
	}

}
