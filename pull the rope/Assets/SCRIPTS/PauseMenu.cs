using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject Pause;

    public void TogglePause()
        {
        Pause.SetActive(!Pause.activeSelf);
        }

    public void ToMenu ()
    {
        SceneManager.LoadScene("Menu");
    }
	
    public void Quit()
    {
        Application.Quit();
    }
}
