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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (About.activeSelf)
            {
                About.SetActive(false);
            }

            if (Settings.activeSelf)
            {
                DontSaveSettings();
            }
        }
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

    public void DontSaveSettings()
    {
        Settings.SetActive(false);
    }
}
