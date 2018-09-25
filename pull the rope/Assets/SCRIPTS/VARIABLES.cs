using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VARIABLES : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Iz", 0);
        PlayerPrefs.SetInt("De", 0);
        PlayerPrefs.Save();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
