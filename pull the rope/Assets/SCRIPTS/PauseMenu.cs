using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject Pause;

    public void TogglePause()
        {
       
        Pause.SetActive(true);
        Time.timeScale = 0;
    }
    public void Volver()
    {
        
        Pause.SetActive(false);
        Time.timeScale = 1;
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
