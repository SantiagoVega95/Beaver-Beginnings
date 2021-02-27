using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class mainmenu : MonoBehaviour
{
    // ------------ (BUTTON) Start New Game -----------
    public void StartGame()
    {
        SceneManager.LoadScene("Trainstaion");
    }

    // ------------ (BUTTON) Exit Game -----------
    public void ExitGame()
    {
        Debug.Log("Exited game");
        Application.Quit();
    }

}
