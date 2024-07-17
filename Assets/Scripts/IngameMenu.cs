using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneMenu : MonoBehaviour
{
    public Camera camOutside;
    public Camera camInside;

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void StartSimulation()
    {
        //add function to start timer and lock UI etc. here
    }

    public void SwitchCamera()
    {
        camOutside.enabled = !camOutside.enabled;
        camInside.enabled = !camInside.enabled;
    }
}
