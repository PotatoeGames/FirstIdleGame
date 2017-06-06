using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//added includes
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour 
{
	
	[SerializeField] int playerEssence = 0; 	  //basic useable currency
	[SerializeField] int totalEssence = 0;		  //total amount of currency acquired in current realm

	[SerializeField] int baseValue = 0; 		  //total value of current operation

	[SerializeField] int dronePopulation = 0; 	  //number of active drones
	[SerializeField] int droneReproduction = 0;   //rate of increase in amount of drones
	[SerializeField] float droneValue = 1; 		  //harvesting multiplier

	[SerializeField] int essenceProduction = 0;   //essence harvesting rate
	[SerializeField] int idleProduction = 0; 	  //essence harvesting rate when idle
	[SerializeField] float idleMultiplier = 10;    //scalar for essence production when app is closed

	[SerializeField] int playerCredits = 0; 	  //amount of permanent-upgrade currency

	[SerializeField] int playerDarkMatter = 0;    //amount of direct-multiplying currency
	[SerializeField] int darkMatterBonus = 100;     //percentage bonus from total dark matter

	public Text statText;

	void Start () 
	{
		statText = GameObject.Find ("Canvas/StatText").GetComponent<Text> ();
		StartCoroutine (IncrementStats());
	}

	void Update () 
	{
		TestStatUpdate ();
	}

	void TestStatUpdate() 
	{
		statText.text = 
			"Player Essence = " + playerEssence + '\n' + 
			"Total Essence = " + totalEssence + '\n' +
			"Drone Population = " + dronePopulation + '\n' + 
			"Drone Reproduction = " + droneReproduction + '\n' + 
			"Drone Value = " + droneValue + '\n' + 
			"Essence Production = " + essenceProduction + '\n' + 
			"Idle Production = " + idleProduction + '\n' + 
			"Idle Multiplier = " + idleMultiplier + "% \n" +
			"Player Credits = " + playerCredits + '\n' + 
			"Player Dark Matter = " + playerDarkMatter + '\n' +
			"Dark Matter Bonus = " + darkMatterBonus + '%';
	}

	IEnumerator IncrementStats()
	{
		yield return new WaitForSeconds (1);
		dronePopulation += droneReproduction;
		essenceProduction = Mathf.RoundToInt(droneValue * dronePopulation * (darkMatterBonus / 100));
		idleProduction = Mathf.RoundToInt(essenceProduction * idleMultiplier / 100);
		playerEssence += essenceProduction;
		totalEssence += essenceProduction;
		StartCoroutine (IncrementStats());
	}

	public void AddDrone()
	{
		dronePopulation++;
	}

	public void AddDroneMultiplier()
	{
		droneValue += 0.1f;
	}

	public void AddDarkMatter()
	{
		playerDarkMatter += 1;
		darkMatterBonus = 100 + (playerDarkMatter * 10);
	}

	public void AddIdleMultiplier()
	{
		if (idleMultiplier < 100)
		idleMultiplier += 10;
	}

	public void AddDroneReproduction()
	{
		droneReproduction += 1;
	}
}
