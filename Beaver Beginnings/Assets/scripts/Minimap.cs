using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    // ------------ (BUTTON) to the Bar -----------
    public void Bar()
    {
        SceneManager.LoadScene("BAR");
    }

    // ------------ (BUTTON) to the Cafe -----------
    public void cafe()
    {
       SceneManager.LoadScene("Cafe");
    }

// ------------ (BUTTON) to the  ---Trainstaion--------
     public void trainstaion()
    {
        SceneManager.LoadScene("Trainstaion");
    }

    // ------------ (BUTTON) to the Home -----------
     public void home()
    {
        SceneManager.LoadScene("Home");
    }
}
