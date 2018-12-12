using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public GameObject Pause;

	//Activate or deactivate the pause menu
    public void TogglePause()
    {
        Pause.SetActive(true);
    }
    public void Volver()
    {        
        Pause.SetActive(false);
    }
}
