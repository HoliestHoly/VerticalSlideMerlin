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
        speed = -10f;
        menuIsUp = false;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, speed, 3f);
        if (menuIsUp == false)
        {
            if (Input.GetMouseButtonDown(1))
            {
                transform.position = new Vector2(startPosition.x, startPosition.y);
                menuIsUp = true;
            }
        }
        if (menuIsUp == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                transform.position = new Vector2(startPosition.x, startPosition.y);
                menuIsUp = false;
            }
        }
    }
}
