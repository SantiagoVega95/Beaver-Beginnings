using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
      // ------------ (BUTTON) trainstaion -----------
    public void trainstation()
    {
        SceneManager.LoadScene("Trainstaion");
    }

      // ------------ (BUTTON) Home -----------
    public void home()
    {
        SceneManager.LoadScene("Home");
    }

       // ------------ (BUTTON) Bar -----------
    public void Bar()
    {
        SceneManager.LoadScene("BAR");
    }

       // ------------ (BUTTON) Cafe -----------
    public void cafe()
    {
        SceneManager.LoadScene("Cafe");
    }
}
