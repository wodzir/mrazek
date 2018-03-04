using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    float x = 0;
    
   
	// Update is called once per frame
	void Update () {
        //pohyb WASD
        //D 
        if (Input.GetKey("d"))
        {
            x = x + Time.deltaTime * 5;
            transform.position = new Vector3(x, transform.position.y, 0);           
        }
        //A
        if (Input.GetKey("a"))
        {
            x = x - Time.deltaTime * 5;
            transform.position = new Vector3(x, transform.position.y, 0);      
        }
        //pobyb konec
        //skok
		//skok ještě není plynulá animace ( WIP )
        if (Input.GetKeyDown("space"))
        {
            float vyskaSkoku = transform.position.y;
            vyskaSkoku = vyskaSkoku + Time.deltaTime * 200;
            transform.position = new Vector3(transform.position.x, vyskaSkoku, 0);
        }         
    }
}
