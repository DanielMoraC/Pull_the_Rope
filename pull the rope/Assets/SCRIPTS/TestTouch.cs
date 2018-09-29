using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TestTouch : MonoBehaviour {
    Touch myTouch;
    Touch[] myTouches;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
    /*
	void Update () {
        myTouch = Input.GetTouch(0);

        for(int i = 0; i < Input.touchCount; i++)
        {
            if (myTouch.position.x < 0 && transform.position.x > -5)
            {
                transform.Translate(-0.1f,0,0);
                //Debug.Log("Hola");
            }
            if (myTouch.position.x > 0 && transform.position.x < 5)
            {
                transform.Translate(+0.1f, 0, 0);
                //Debug.Log("Adios");
            }
        }
	}*/
    public void MoverI()
    {
        transform.Translate(-0.5f, 0, 0);
        Debug.Log("Adios");
    }
    public void MoverD()
    {
        transform.Translate(+0.5f, 0, 0);
        Debug.Log("Hola");
    }
}
