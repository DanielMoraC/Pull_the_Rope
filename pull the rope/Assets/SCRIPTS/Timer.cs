using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timertext;
    //public float startTime;
    public float seconds;

	void Start () {
        //startTime = Time.time;
        seconds = PlayerPrefs.GetFloat("Segundos");
    }
	
	// Update is called once per frame
	void Update () {
        seconds = seconds + 1 * Time.deltaTime;
        timertext.text = "" + seconds;
        PlayerPrefs.SetFloat("Segundos", seconds);
        /*
        PlayerPrefs.SetString("Segundos", seconds);
        float t = Time.time - startTime;
       // string minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("f2");
        timertext.text = seconds;*/
    }
}
