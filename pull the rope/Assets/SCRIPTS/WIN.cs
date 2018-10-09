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
        /*mapa = 0;
        Iz = 0;
        De = 0;
        print("Mapa2 = " + PlayerPrefs.GetInt("Map"));
        Iz = PlayerPrefs.GetInt("Izq");
        De = PlayerPrefs.GetInt("Der");
        mapa = PlayerPrefs.GetInt("Map");
        print("Mapa3 = " + PlayerPrefs.GetInt("Map"));*/

        PlayerPrefs.GetFloat("Segundos");
        continua = true;
    }

    // Update is called once per frame
    void Update () {
        #region timer
        if (continua)
        {
            seconds = seconds + 1 * Time.deltaTime;
            timertext.text = "" + seconds.ToString("0");
        }
        #endregion timer
    }


    private void OnTriggerEnter2D(Collider2D col)
    {


        if (col.gameObject.tag == "finali")
        {
            continua = false;
            if (PlayerPrefs.GetFloat("Segundos") > seconds)
            {
                PlayerPrefs.SetFloat("Segundos", seconds);
            }
            Won.SetActive(true);
        }
        if (col.gameObject.tag == "finald")
        {
            continua = false;
            if (PlayerPrefs.GetFloat("Segundos") > seconds)
            {
                PlayerPrefs.SetFloat("Segundos", seconds);
            }
            Won.SetActive(true);
        }

        #region mapa1

        /*
        if (mapa == 0) {
            if (col.gameObject.tag == "finali" && Iz == 0)
            {
                mapa = 1;
                Iz = 1;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
                print("Mapa = " + PlayerPrefs.GetInt("Map"));
                SceneManager.LoadScene("mapa2");
                
            }
            if (col.gameObject.tag == "finald" && De == 0)
            {
                mapa = 1; 
                De = 1;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
                print("Mapa = " + PlayerPrefs.GetInt("Map"));
                SceneManager.LoadScene("mapa2");
                
            }
        }*/

        #endregion mapa1


        #region mapas
        /*
        if (mapa == 1)
        {
            if (col.gameObject.tag == "finali" && Iz == 1)
            {
                Won.SetActive(true);
                mapa = 0;
                De = 0;
                Iz = 0;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
            }
            else if (col.gameObject.tag == "finali" && Iz == 0)
            {
                
                mapa=2;
                Iz = 1;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
                SceneManager.LoadScene("mapa3");
            }
            if (col.gameObject.tag == "finald" && De == 1)
            {
                Won.SetActive(true);
                mapa = 0;
                De = 0;
                Iz = 0;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
            }
            else if (col.gameObject.tag == "finald" && De == 0)
            {
                
                mapa =2;
                De = 1;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
                SceneManager.LoadScene("mapa3");
            }
        }
        if (mapa == 2)
        {
            if (col.gameObject.tag == "finali" && Iz == 1)
            {
                Won.SetActive(true);
                mapa = 0;
                De = 0;
                Iz = 0;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
            }
            if (col.gameObject.tag == "finald" && De == 1)
            {
                Won.SetActive(true);
                mapa = 0;
                De = 0;
                Iz = 0;
                PlayerPrefs.SetInt("Map", mapa);
                PlayerPrefs.SetInt("Izq", Iz);
                PlayerPrefs.SetInt("Der", De);
            }
        }*/
        #endregion mapas

    }

}
