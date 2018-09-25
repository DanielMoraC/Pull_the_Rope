using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WIN : MonoBehaviour {

    public GameObject Winner1;
    public GameObject Winner2;

    public int mapa=1;

    public bool Iz = false;
    public bool De = false;

    // Use this for initialization
    void Start () {
        PlayerPrefs.GetInt("IZ");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D col)
    {
        if (mapa == 1) {
            if (col.gameObject.tag == "finali" && !Iz)
            {
                SceneManager.LoadScene("mapa2");
                mapa++;
                Iz = true;
                //Debug.Log("hola");

            }
            if (col.gameObject.tag == "finald" && !De)
            {
                SceneManager.LoadScene("mapa2");
                mapa++;
                De = true;
                PlayerPrefs.SetInt("IZ", 1);
                //Debug.Log("Adios");
            }
        }
        if (mapa == 2)
        {
            if (col.gameObject.tag == "finali" && Iz)
            {
                SceneManager.LoadScene("WIN");

            }
            else if (col.gameObject.tag == "finali" && !Iz)
            {
                SceneManager.LoadScene("mapa3");
                mapa++;
                Iz = true;
                //Debug.Log("Adios");
            }
            if (col.gameObject.tag == "finald" && De)
            {
                SceneManager.LoadScene("WIN");
            }
            else if (col.gameObject.tag == "finali" && !De)
            {
                SceneManager.LoadScene("mapa3");
                mapa++;
                De = true;
                //Debug.Log("Adios");
            }
        }
        if (mapa == 3)
        {
            if (col.gameObject.tag == "finali" && Iz)
            {
                SceneManager.LoadScene("WIN");
            }
            if (col.gameObject.tag == "finald" && De)
            {
                SceneManager.LoadScene("WIN");
            }
        }
    }
    
}
