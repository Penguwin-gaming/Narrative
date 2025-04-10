using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTracker : MonoBehaviour
{
    public int location;
    public bool hasMedkit;
    public bool hasCure;
    public bool hasCode;
    public bool lockerOpen;
    public bool hasFuse;
    public bool hasKey;
    public bool hasDan;
    public bool hasMary;
    public bool powerIsOn;
    public bool canEscape;
    public GameObject starting;
    public GameObject hall1;
    public GameObject Hall2;
    public GameObject Hall3;
    public GameObject Locker;
    public GameObject Light;
    public GameObject Breaker;
    public GameObject Dirty;
    public GameObject Dan;
    public GameObject Mary;
    public GameObject Elevator;
    public GameObject Lab;
    public GameObject mapScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        starting.gameObject.SetActive(false);
        hall1.gameObject.SetActive(false);
        Hall2.gameObject.SetActive(false);
        Hall3.gameObject.SetActive(false);
        Locker.gameObject.SetActive(false);
        Light.gameObject.SetActive(false);
        Breaker.gameObject.SetActive(false);
        Dirty.gameObject.SetActive(false);
        Dan.gameObject.SetActive(false);
        Mary.gameObject.SetActive(false);
        Elevator.gameObject.SetActive(false);
        Lab.gameObject.SetActive(false);

        if (location == 0)
        {
            starting.gameObject.SetActive(!starting.gameObject.activeInHierarchy);
        }

        if (location == 1)
        {
            hall1.gameObject.SetActive(!hall1.gameObject.activeInHierarchy);
        }
        
        if (location == 2)
        {
            Locker.gameObject.SetActive(!Locker.gameObject.activeInHierarchy);
        }

        if (location == 3)
        {
            Dirty.gameObject.SetActive(!Dirty.gameObject.activeInHierarchy);
        }

        if (location == 4)
        {
            Light.gameObject.SetActive(!Light.gameObject.activeInHierarchy);
        }

        if (location == 5)
        {
            Breaker.gameObject.SetActive(!Breaker.gameObject.activeInHierarchy);
        }

        if (location == 6)
        {
            Hall2.gameObject.SetActive(!Hall2.gameObject.activeInHierarchy);
        }

        if (location == 7)
        {
            Hall3.gameObject.SetActive(!Hall3.gameObject.activeInHierarchy);
        }

        if (location == 8)
        {
            Dan.gameObject.SetActive(!Dan.gameObject.activeInHierarchy);
        }

        if (location == 9)
        {
            Lab.gameObject.SetActive(!Lab.gameObject.activeInHierarchy);
        }

        if (location == 10)
        {
            Elevator.gameObject.SetActive(!Elevator.gameObject.activeInHierarchy);
        }

        if (location == 11)
        {
            Mary.gameObject.SetActive(!Mary.gameObject.activeInHierarchy);
        }
    }
    public void moveRoom0()
    {
        location = 0;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom1()
    {
        location = 1;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom2()
    {
        location = 2;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom3()
    {
        location = 3;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom4()
    {
        location = 4;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom5()
    {
        location = 5;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom6()
    {
        location = 6;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom7()
    {
        location = 7;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom8()
    {
        location = 8;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom9()
    {
        location = 9;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom10()
    {
        location = 10;
        mapScreen.gameObject.SetActive(false);
    }
    public void moveRoom11()
    {
        location = 11;
        mapScreen.gameObject.SetActive(false);
    }

    public void SpawnScreen(GameObject s)
    {
        GameObject screen = Instantiate(s);
        screen.transform.position = new Vector3(0f, 0f, 0f);

    }

}
