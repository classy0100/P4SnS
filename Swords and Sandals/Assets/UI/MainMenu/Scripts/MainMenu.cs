using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject creditsMenu;

   public void NewGame()
    {
        DisableMainMenuButtons();
        StartCoroutine(StartNewGame());
    }

    public void Settings()
    {
        DisableMainMenuButtons();
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void Credits()
    {
        DisableMainMenuButtons();
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    // Global buttons

    public void GoBackToMain()
    {
        EnableMainMenuButtons();
        settingsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    void DisableMainMenuButtons()
    {
       foreach (var button in mainMenu.GetComponentsInChildren<Button>(true))
        {
            button.interactable = false;
        }
    }

    void EnableMainMenuButtons()
    {
        foreach (var button in mainMenu.GetComponentsInChildren<Button>(true))
        {
            button.interactable = true;
        }
    }

    IEnumerator StartNewGame()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("Prologue");
    }
}
