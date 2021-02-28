using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scene after Opening Scene
public class B : MonoBehaviour
{
    // Start is called before the first frame update
    int click;
    public GameObject t1;
    public GameObject t2;
    public GameObject t3;
    public GameObject t4;
    public GameObject t5;
    public GameObject t6;
    public GameObject t7;
    public GameObject t8;
    public GameObject t9;
    public GameObject t10;
    public GameObject t11;
    public GameObject t12;
    public GameObject t13;
    public GameObject Speechbox;
    public GameObject Name;
    public GameObject CharacterName;
    public GameObject CharacterNameUnknown;
    public GameObject Character;

    void Start()
    {
        click = 14;
        Speechbox.SetActive(false);
        Character.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 13)
        {
            t1.SetActive(true);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 12) //c
        {
            t1.SetActive(false);
            t2.SetActive(true);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(true);
        }

        if (click == 11) //mc
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(true);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 10) //c
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(true);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(true);
        }

        if (click == 9) //mc
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(true);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 8) //c
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(true);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(true);
        }

        if (click == 7) //mc
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(true);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 6) //c
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(true);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(true);
        }

        if (click == 5) //mc
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(true);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 4) //c
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(true);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 3) //mc
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(true);
            t12.SetActive(false);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 2) //c
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(true);
            t13.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 1) //n
        {
            t1.SetActive(false);
            t2.SetActive(false);
            t3.SetActive(false);
            t4.SetActive(false);
            t5.SetActive(false);
            t6.SetActive(false);
            t7.SetActive(false);
            t8.SetActive(false);
            t9.SetActive(false);
            t10.SetActive(false);
            t11.SetActive(false);
            t12.SetActive(false);
            t13.SetActive(true);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 0)
        {
            SceneManager.LoadScene("Home");
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
