using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dynamite : MonoBehaviour {
	float spawnTimer;
	float destroyTimer;
	bool canExplode;
	int xPosition = 0;
	int yPosition = 0;
	Destruction destruction;
	public GameObject _spritemask;

	void Awake(){
		spawnTimer = 3f;
		destroyTimer = 0f;
		canExplode = true;
		destruction = GameObject.FindObjectOfType(typeof(Destruction)) as Destruction;







		//Destroy (gameObject, 3f);
	}

	// Update is called once per frame
	void Update () 
	{
		//makes dynamite leave a hole and delete itself
		spawnTimer -= Time.deltaTime;	
		if(spawnTimer <= 0) 
		{
			destroyTimer -= Time.deltaTime;

			if (canExplode) 
			{ 
				destruction.Explosion((int)transform.position.x, (int)transform.position.y, 100); 
			}

			if (destroyTimer <= 0) 
			{
				Destroy (gameObject);

			}

		}

	}
	 //code that might be helpful if there was a particle system


}

