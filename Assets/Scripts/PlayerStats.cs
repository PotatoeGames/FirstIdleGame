using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//added includes
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour 
{
	
	[SerializeField] private int playerEssence = 0; 	  //basic useable currency
	[SerializeField] private int totalEssence = 0;		  //total amount of currency acquired in current realm

	[SerializeField] private int baseValue = 0; 		  //total value of current operation

	[SerializeField] private int dronePopulation = 0; 	  //number of active drones
	[SerializeField] private int droneReproduction = 0;   //rate of increase in amount of drones
	[SerializeField] private float droneValue = 1; 		  //harvesting multiplier

	[SerializeField] private int essenceProduction = 0;   //essence harvesting rate
	[SerializeField] private int idleProduction = 0; 	  //essence harvesting rate when idle
	[SerializeField] private float idleMultiplier = 10;   //scalar for essence production when app is closed

	[SerializeField] private int playerCredits = 0; 	  //amount of permanent-upgrade currency

	[SerializeField] private int playerDarkMatter = 0;    //amount of direct-multiplying currency
	[SerializeField] private int darkMatterBonus = 100;   //percentage bonus from total dark matter

	public Text statText;
	public Text playerEssenceText;
	public Text dronePopulationText;
	public Text playerCreditsText;
	public Text essenceProductionText;

	void Start () 
	{
		//Nick i turned this off because my gym doesnt have it therefore the entire script doesnt work.
		//statText = GameObject.Find ("Canvas/StatText").GetComponent<Text> ();

		//if (statText != null)
			StartCoroutine (IncrementStats());

		//might need the same gameobject.find? idk
		//if (playerEssenceText != null)
			StartCoroutine (UpdateUI());

		//if (dronePopulationText != null)
			//StartCoroutine (UpdateUI());

		//if (playerCreditsText != null)
			//StartCoroutine (UpdateUI());
		
	}

	void Update () 
	{
		
		if (statText != null) {
			TestStatUpdate ();
		}
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

	IEnumerator UpdateUI()
	{
		yield return new WaitForSeconds (1);
		if (playerEssenceText != null)
		playerEssenceText.text = "Essence: \n" + playerEssence;
		if (dronePopulationText != null)
		dronePopulationText.text = "Drones: \n" + dronePopulation;
		if (playerCreditsText != null)
		playerCreditsText.text = "Credits: \n" + playerCredits;
		if (essenceProductionText != null)
		essenceProductionText.text = "Rate: \n" + essenceProduction;
		StartCoroutine (UpdateUI());
	}

	//incrementers
	public void IncPlayerEssence(int increment){playerEssence += increment;}
	public void IncTotalEssence(int increment){totalEssence += increment;}
	public void IncBaseValue(int increment){baseValue += increment;}
	public void IncDronePopulation(int increment){dronePopulation += increment;}
	public void IncDroneReproduction(int increment){droneReproduction += increment;}
	public void IncDroneValue(float increment){droneValue += increment;}
	public void IncEssenceProduction(int increment){essenceProduction += increment;}
	public void IncIdleProduction(int increment){idleProduction += increment;}
	public void IncIdleMultiplier(float increment){idleMultiplier += increment;}
	public void IncPlayerCredits(int increment){playerCredits += increment;}
	public void IncPlayerDarkMatter(int increment){playerDarkMatter += increment;}
	//change to calculate bonus from dark matter // do we need another value? //dark matter/ dark matter value/ dark matter bonus
	public void IncDarkMatterBonus(int increment){darkMatterBonus += increment;} 


	public void IncDarkMatter()
	{
		playerDarkMatter += 1;
		darkMatterBonus = 100 + (playerDarkMatter * 10);
	}

	public void IncIdleMultiplier()
	{
		if (idleMultiplier < 100)
		idleMultiplier += 10;
	}

	// Getters
	public int GetPlayerEssence(){return playerEssence;}
	public int GetTotalEssence(){return totalEssence;}
	public int GetBaseBalue(){return baseValue;}
	public int GetDronePopulation(){return dronePopulation;}
	public int GetDroneReproduction(){return droneReproduction;}
	public float GetDroneValue(){return droneValue;}
	public int GetEssenceProduction(){return essenceProduction;}
	public int GetIdleProduction(){return idleProduction;}
	public float GetIdleMultiplier(){return idleMultiplier;}
	public int GetPlayerCredits(){return playerCredits;}
	public int GetPlayerDarkMatter(){return playerDarkMatter;}
	public int GetDarkMatterBonus(){return darkMatterBonus;}
}
