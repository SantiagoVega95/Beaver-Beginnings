using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class B1 : MonoBehaviour
{
    // Start is called before the first frame update
    int click;

    void Start()
    {
        click = 1;
    }

    // Update is called once per frame
    void Update()
    {

        if (click == 0)
        {
            SceneManager.LoadScene("mainmenu");
        }
        if (Input.GetButtonDown("Fire1"))
        {
            AddScore();
        }
    }

    public void AddScore()
    {
        click -= 1;
    }

}
