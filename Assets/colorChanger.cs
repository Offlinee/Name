using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    public SpriteRenderer rend;
    public Color color;
    public float movespeed = 5f;
    public float rotationspeed = 360;
    public TrailRenderer trailRend;
	// Use this for initialization
	void Start ()
    {
        rend.color = color;
        rend.color = new Color(0, 1, 0);
        transform.Translate(-5f, 0, 0, Space.World);
		transform.position = new Vector3(-5f, transform.position.y);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -rotationspeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(-movespeed * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.green; //new color(0, 1, 0)
            trailRend.startColor = new Color(1, 0, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(movespeed / 2 * Time.deltaTime, 0, 0, Space.Self);
            rend.color = Color.red; 
        }
    }
   }
