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
        SceneManager.LoadScene("Trainstaion 1");
    }

      // ------------ (BUTTON) Home -----------
    public void home()
    {
        SceneManager.LoadScene("Home 1");
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
