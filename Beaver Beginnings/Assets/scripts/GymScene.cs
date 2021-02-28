using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GymScene : MonoBehaviour
{
    // Start is called before the first frame update
    int click;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject Speechbox;
    public GameObject Name;
    public GameObject Character;

    void Start()
    {
        click = 3;
        Speechbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 2)
        {
            t1.SetActive(true);
            t2.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 1)
        {
            t1.SetActive(false);
            t2.SetActive(true);
            Speechbox.SetActive(true);
            Name.SetActive(true);
        }

        if (click == 0)
        {
            SceneManager.LoadScene("minimap");
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
