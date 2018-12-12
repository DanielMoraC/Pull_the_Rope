using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WIN : MonoBehaviour {

    public GameObject Winner1;
    public GameObject Winner2;
    public GameObject Won;

    

    public int mapa;   
    public int Iz;
    public int De;


    public Text timertext;
    public float seconds;
    public bool continua;

    // Use this for initialization
    void Start () {

        PlayerPrefs.GetFloat("Segundos");
        continua = true;
    }

    // Update is called once per frame
    void Update () {

		//Timer
        if (continua)
        {
            seconds = seconds + 1 * Time.deltaTime;
            timertext.text = "" + seconds.ToString("0");
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {

		//If the rope touch the a player it wins and if he wins in less time than the highscore it changes
        if (col.gameObject.tag == "finali")
        {
            continua = false;
            if (PlayerPrefs.GetFloat("Segundos") < seconds)
            {
                PlayerPrefs.SetFloat("Segundos", seconds);
            }
            Won.SetActive(true);
        }
        if (col.gameObject.tag == "finald")
        {
            continua = false;
            if (PlayerPrefs.GetFloat("Segundos") < seconds)
            {
                PlayerPrefs.SetFloat("Segundos", seconds);
            }
            Won.SetActive(true);
        }

    }

}
