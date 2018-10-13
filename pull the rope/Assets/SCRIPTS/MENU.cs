using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour {

    public Text highS;

	// Use this for initialization
	void Start () {
        highS.text = PlayerPrefs.GetFloat("Segundos").ToString("0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Puntuaciones()
    {
        SceneManager.LoadScene("Scores");
    }
    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
