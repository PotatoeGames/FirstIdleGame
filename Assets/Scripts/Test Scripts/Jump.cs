using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour 
{
	public int bounceFactor;
	// Use this for initialization
	void Start () 
	{
		bounceFactor = 100;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public void Bounce() 
	{
		this.GetComponent<Rigidbody> ().AddForce(new Vector3(0,bounceFactor,0));
		bounceFactor += 10;
	}
}
