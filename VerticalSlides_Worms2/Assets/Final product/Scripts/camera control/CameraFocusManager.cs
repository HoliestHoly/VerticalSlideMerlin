using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFocusManager : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	public GameObject dynamite;
	public GameObject enemy;
	public Camera cam;
	void Start () {
		player = GameObject.Find ("player");
	}
		

	void Update () {
		dynamite = GameObject.Find ("dynamite");
		if (CameraFocus._focus == 3) 
		{ //makes it so that the enemy can never get launched outside of the viewport
			
			Vector3 viewPos = cam.WorldToViewportPoint (enemy.transform.position);

			if (viewPos.x <= 0.2f || viewPos.x >= 0.8f || viewPos.y <= 0.2f || viewPos.y >= 0.8f) 
				{
				
					var z = enemy.transform.position;
					z.z = cam.transform.position.z;

					cam.transform.position = Vector3.Lerp (cam.transform.position, z, Time.deltaTime * 0.9f);
				}
		} else if (CameraFocus._focus == 2) { //tracks the dynamite
			cam.transform.position = new Vector3 (dynamite.transform.position.x, dynamite.transform.position.y, -10);
		} else if (CameraFocus._focus == 1) { //tracks the player
			cam.transform.position = new Vector3 (player.transform.position.x, player.transform.position.y, -10);

		}
	}
}
