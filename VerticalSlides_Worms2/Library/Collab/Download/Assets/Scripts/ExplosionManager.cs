using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionManager : MonoBehaviour
{
    //Making the radius of explosion
    public float explosionRadius = 5.0f;
    public float DetnonationTime = 5.0f;
    public float upForce = 5.0f;
    public GameObject bomb;

    // Use this for initialization
    private void Start()
    {


    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        DetnonationTime -= Time.deltaTime;
        Dentonate();
    }


    private void Dentonate()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(bomb.transform.position, explosionRadius);
        if (bomb != null)
        {
            if (DetnonationTime < 0)
            {
                Destroy(bomb);
                foreach (Collider2D hit in colliders)
                {
                    Rigidbody2D rb = hit.GetComponent<Rigidbody2D>();

                    if (rb != null && rb != GetComponent<Rigidbody2D>())
                    {
                        rb.AddForce(transform.up * upForce, ForceMode2D.Impulse);
                    }
                }
                //if (Physics2D.OverlapCircleAll(bombPosition.transform.position, explosionRadius){ }

            }
        }
    }

}
