using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timertext;
    public float seconds;

	void Start () {
        seconds = PlayerPrefs.GetFloat("Segundos");
    }
	
	// Update is called once per frame
	void Update () {
        seconds = seconds + 1 * Time.deltaTime;
        timertext.text = "" + seconds.ToString("0");
        PlayerPrefs.SetFloat("Segundos", seconds);
    }
}
