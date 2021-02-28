using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningSceneScript : MonoBehaviour
{
    int click;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;
    public GameObject t6;
    public GameObject t7;
    public GameObject t8;
    public GameObject Speechbox;
    public GameObject Name;

    void Start()
    {
        click = 9;
        Speechbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 8)
        {
            t1.SetActive(true);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 7)
        {
            t1.SetActive(false);
            t2.SetActive(true);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 6)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(true);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 5)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(true);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 4)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(true);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 3)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(true);
            t7.SetActive(false);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 2)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(true);
            t8.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 1)
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(true);
            Speechbox.SetActive(true);
            Name.SetActive(false);
        }

        if (click == 0)
        {
            SceneManager.LoadScene("Trainstaion");
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
