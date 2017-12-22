using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour {
    //Making the radius of explosion
    public float explosionRadius = 5.0f;
    public float DetnonationTime;
    public float upForce = 5.0f;
    public GameObject bomb;

    // Use this for initialization
    void Start () {
        DetnonationTime = 5.0f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	}


    void Dentonate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(bomb.transform.position, explosionRadius);
        if (bomb != null)
        {
            new WaitForSeconds(DetnonationTime);
           if (DetnonationTime == 0)
            {
                Destroy(bomb);
                foreach(Collider2D hit in colliders)
                {
                    Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();
                    rb.AddForce(transform.forward * upForce);
                }
                //if (Physics2D.OverlapCircleAll(bombPosition.transform.position, explosionRadius){ }
                
            }
        }
    } 

}
