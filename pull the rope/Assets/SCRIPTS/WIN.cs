using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WIN : MonoBehaviour {

    public GameObject Winner1;
    public GameObject Winner2;
    public GameObject Won;

    public int mapa=0;
    
    public int Iz = 0;
    public int De = 0;

    
    // Use this for initialization
    void Start () {
        Iz = PlayerPrefs.GetInt("Izq");
        De = PlayerPrefs.GetInt("Der");
        mapa = PlayerPrefs.GetInt("Map");
    }
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetInt("Map", mapa);
        PlayerPrefs.SetInt("Izq", Iz);
        PlayerPrefs.SetInt("Der", De);
    }
    /*
    public void Borrar()
    {
        //PlayerPrefs.DeleteAll();
        PlayerPrefs.DeleteKey("Izq");
    }*/

    private void OnTriggerStay2D(Collider2D col)
    {
        if (mapa == 0) {
            if (col.gameObject.tag == "finali" && Iz == 0)
            {
                SceneManager.LoadScene("mapa2");
                mapa=1;
                Iz = 1;
            }
            if (col.gameObject.tag == "finald" && De == 0)
            {
                SceneManager.LoadScene("mapa2");
                mapa=1;;
                De = 1;
            }
        }
        if (mapa == 1)
        {
            if (col.gameObject.tag == "finali" && Iz == 1)
            {
                Won.SetActive(true);
                PlayerPrefs.DeleteAll();
            }
            else if (col.gameObject.tag == "finali" && Iz == 0)
            {
                SceneManager.LoadScene("mapa3");
                mapa=2;
                Iz = 1;
            }
            if (col.gameObject.tag == "finald" && De == 1)
            {
                Won.SetActive(true);
                PlayerPrefs.DeleteAll();
            }
            else if (col.gameObject.tag == "finali" && De == 0)
            {
                SceneManager.LoadScene("mapa3");
                mapa=2;
                De = 1;
            }
        }
        if (mapa == 2)
        {
            if (col.gameObject.tag == "finali" && Iz == 1)
            {
                Won.SetActive(true);
                PlayerPrefs.DeleteAll();
            }
            if (col.gameObject.tag == "finald" && De == 1)
            {
                Won.SetActive(true);
                PlayerPrefs.DeleteAll();
            }
        }
    }
    
}
