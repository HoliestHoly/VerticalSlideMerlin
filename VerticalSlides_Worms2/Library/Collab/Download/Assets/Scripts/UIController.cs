using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
    RectTransform weaponMenu;
    Vector2 startPosition;
    public float speed;
    public bool menuIsUp;


    // Use this for initialization
    void Start () {
        weaponMenu = GameObject.Find("Canvas").GetComponent<RectTransform>();
        startPosition = transform.position;
        speed = 0f;
        menuIsUp = false;
    }
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(transform.position);
        if (Input.GetMouseButtonDown(1) && menuIsUp == false)
        {
            menuIsUp = true;
        }
        else if (Input.GetMouseButtonDown(1) && menuIsUp == true)
        {
            menuIsUp = false;
        }
        if (menuIsUp == false && transform.position.x < 2080)
        {
            speed = 10f;
            transform.Translate(speed, 0f, 0f);
        }
        if (menuIsUp == true && transform.position.x > 1700)
        {
            speed = -10f;
            transform.Translate(speed, 0f, 0f);
        }
    }
}
