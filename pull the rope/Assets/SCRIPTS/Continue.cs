using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour {
    Touch myTouch;
    Touch[] myTouches;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myTouch = Input.GetTouch(0);

        for (int i = 0; i < Input.touchCount; i++)
        {
            SceneManager.LoadScene("Menu");
            //Debug.Log("Hola");
        }
    }
}
