using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Navigation : MonoBehaviour {
    public void GoTo(string scene)
    {
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}
