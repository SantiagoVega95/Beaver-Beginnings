using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Scene after Opening Scene
public class A : MonoBehaviour
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
    public GameObject t14;
    public GameObject t15;
    public GameObject t16;
    public GameObject t17;
    public GameObject t18;
    public GameObject t19;
    public GameObject t20;
    public GameObject Speechbox;
    public GameObject Name;
    public GameObject CharacterName;
    public GameObject CharacterNameUnknown;
    public GameObject Character;

    void Start()
    {
        click = 21;
        Speechbox.SetActive(false);
        Character.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (click == 20) //n
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 19) //c
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(true);
        }

        if (click == 18) //mc
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 17) //n
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 16) //c
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(true);
        }

        if (click == 15) //mc
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 14) //n
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 13) //mc
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 12) //c
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 11) //mc
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 10) //c
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 9) //mc
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 8) //n
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
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 7) //c
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
            t13.SetActive(false);
            t14.SetActive(true);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 6) //mc
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
            t13.SetActive(false);
            t14.SetActive(false);
            t15.SetActive(true);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 5) //c
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
            t13.SetActive(false);
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(true);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 4) //mc
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
            t13.SetActive(false);
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(true);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(true);
            Character.SetActive(true);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 3) //c
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
            t13.SetActive(false);
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(true);
            t19.SetActive(false);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(true);
            CharacterName.SetActive(true);
            CharacterNameUnknown.SetActive(false);
        }

        if (click == 2) //n
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
            t13.SetActive(false);
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(true);
            t20.SetActive(false);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
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
            t13.SetActive(false);
            t14.SetActive(false);
            t15.SetActive(false);
            t16.SetActive(false);
            t17.SetActive(false);
            t18.SetActive(false);
            t19.SetActive(false);
            t20.SetActive(true);
            Speechbox.SetActive(true);
            Name.SetActive(false);
            Character.SetActive(false);
            CharacterName.SetActive(false);
            CharacterNameUnknown.SetActive(false);
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
