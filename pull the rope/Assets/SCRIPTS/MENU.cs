using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MENU : MonoBehaviour {

    public Text highS;

	// Use this for initialization
	void Start () {

		//Show the time the player is playing
		highS.text = PlayerPrefs.GetFloat("Segundos").ToString("0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Start the game
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

	//Show the highscore
    public void Puntuaciones()
    {
        SceneManager.LoadScene("Scores");
    }

	//Go back to menu
    public void Volver()
    {
        SceneManager.LoadScene("Menu");
    }

	//Exit the game
    public void QuitGame()
    {
        Application.Quit();
    }
    
}
