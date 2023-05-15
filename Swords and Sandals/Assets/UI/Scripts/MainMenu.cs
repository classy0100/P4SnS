using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    private bool isMainActive;

   public void NewGame()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void Settings()
    {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    // Global buttons

    public void GoBackToMain()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
