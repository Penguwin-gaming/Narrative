using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScreen : MonoBehaviour
{
    public GameObject mapScreen;

    // Start is called before the first frame update
    void Start()
    {
        mapScreen.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BringUpScreen()
    {
        mapScreen.gameObject.SetActive(!mapScreen.gameObject.activeInHierarchy);
    }
    public void ChangedRoom()
    {
        mapScreen.gameObject.SetActive(!mapScreen.gameObject.activeInHierarchy);
    }
}
