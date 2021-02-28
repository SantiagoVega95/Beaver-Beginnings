using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class mainmenu : MonoBehaviour
{
    public GameObject Mainmenu;
    public GameObject Instructuins;

    // ------------ (BUTTON) Start New Game -----------
    public void StartGame()
    {
        SceneManager.LoadScene("Opening Scene");
    }

    // ------------ (BUTTON) Instructuins  -----------
    public void instructuins()
    {
        Instructuins.SetActive(true);
         Mainmenu.SetActive(false);
    }

 // ------------ (BUTTON) back   -----------
    public void Back()
    {
        Instructuins.SetActive(false);
         Mainmenu.SetActive(true);
    }
    // ------------ (BUTTON) Exit Game -----------
    public void ExitGame()
    {
        Debug.Log("Exited game");
        Application.Quit();
    }

}
