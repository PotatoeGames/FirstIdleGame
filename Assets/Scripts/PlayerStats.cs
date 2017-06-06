using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//added includes
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
	
	[SerializeField] int playerEssence; 	  //basic useable currency
	[SerializeField] int totalEssence;		  //total amount of currency acquired in current realm

	[SerializeField] int baseValue; 		  //total value of current operation

	[SerializeField] int dronePopulation; 	  //number of active drones
	[SerializeField] float droneReproduction; //rate of increase in amount of drones
	[SerializeField] float droneValue; 		  //harvesting multiplier

	[SerializeField] int essenceProduction;   //essence harvesting rate
	[SerializeField] int idleProduction; 	  //essence harvesting rate when idle
	[SerializeField] float idleMultiplier;    //scalar for essence production when app is closed

	[SerializeField] int playerCredits; 	  //amount of permanent-upgrade currency

	[SerializeField] int playerDarkMatter;    //amount of direct-multiplying currency
	[SerializeField] int darkMatterBonus;     //percentage bonus from total dark matter

	public Text statText;

	void Start () {
		statText = GameObject.Find ("Canvas/StatText").GetComponent<Text> ();
	}

	void Update () {
		TestStatUpdate ();
	}

	void TestStatUpdate() 
	{
		statText.text = "Player Essence = " + playerEssence;
	}
}
