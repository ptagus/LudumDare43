using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{

    public GameObject About;
    public GameObject Settings;

    public void StartGame(int sceneNumber)
    {
        SceneManager.LoadSceneAsync(sceneNumber);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void SaveSettings()
    {
        //Save some settings
        Settings.SetActive(false);
    }
}
