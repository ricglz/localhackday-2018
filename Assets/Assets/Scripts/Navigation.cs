using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {
    public static void GoTo(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }

    public void CloseGame()
    {
    	Application.Quit();
    }
}
