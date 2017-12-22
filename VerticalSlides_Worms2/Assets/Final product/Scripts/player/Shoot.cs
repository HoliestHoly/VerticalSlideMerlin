using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UseWeapon : MonoBehaviour {

	//spawns dynamite on left mouse click
	public GameObject dynamite;


	void Update () {
		if (Input.GetMouseButtonDown(0)) 
		{
			Shoot (); 
		}
	}

	void Shoot () {
		Instantiate (dynamite, transform.position, transform.rotation); 
	}


}