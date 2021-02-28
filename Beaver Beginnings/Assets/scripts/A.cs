using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A : MonoBehaviour
{
    // Start is called before the first frame update
    int click;
    public GameObject t1;
    public GameObject t2;

    void Start()
    {
        click = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 1)
        {
            t1.SetActive(false);
            t2.SetActive(true);
        }

        if (click == 0)
        {
            SceneManager.LoadScene("Minimap");
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
