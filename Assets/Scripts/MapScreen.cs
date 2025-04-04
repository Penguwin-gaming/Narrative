using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScreen : MonoBehaviour
{
    public GameObject mapScreen;
    public GameObject roomIconStart;
    public GameObject roomIconHall1;
    public GameObject roomIconHall2;
    public GameObject roomIconHall3;
    public GameObject roomIconLocker;
    public GameObject roomIconLight;
    public GameObject roomIconBreaker;
    public GameObject roomIconDirty;
    public GameObject roomIconDan;
    public GameObject roomIconMary;
    public GameObject roomIconElevator;
    public GameObject roomIconLab;

    // Start is called before the first frame update
    void Start()
    {
        mapScreen.gameObject.SetActive(false);
        roomIconStart.gameObject.SetActive(false);
        roomIconHall1.gameObject.SetActive(false);
        roomIconHall2.gameObject.SetActive(false);
        roomIconHall3.gameObject.SetActive(false);
        roomIconLocker.gameObject.SetActive(false);
        roomIconLight.gameObject.SetActive(false);
        roomIconBreaker.gameObject.SetActive(false);
        roomIconDirty.gameObject.SetActive(false);
        roomIconDan.SetActive(false);
        roomIconMary.SetActive(false);
        roomIconElevator.SetActive(false);
        roomIconLab.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BringUpScreen()
    {
        mapScreen.gameObject.SetActive(!mapScreen.gameObject.activeInHierarchy);
        roomIconStart.gameObject.SetActive(!roomIconStart.gameObject.activeInHierarchy);
        roomIconHall1.gameObject.SetActive(!roomIconHall1.gameObject.activeInHierarchy);
        roomIconHall2.gameObject.SetActive(!roomIconHall2.gameObject.activeInHierarchy);
        roomIconHall3.gameObject.SetActive(!roomIconHall3.gameObject.activeInHierarchy);
        roomIconLocker.gameObject.SetActive(!roomIconLocker.gameObject.activeInHierarchy);
        roomIconLight.gameObject.SetActive(!roomIconLight.gameObject.activeInHierarchy);
        roomIconBreaker.gameObject.SetActive(!roomIconBreaker.gameObject.activeInHierarchy);
        roomIconDirty.gameObject.SetActive(!roomIconDirty.gameObject.activeInHierarchy);
        roomIconDan.gameObject.SetActive(!roomIconDan.gameObject.activeInHierarchy);
        roomIconMary.gameObject.SetActive(!roomIconMary.gameObject.activeInHierarchy);
        roomIconElevator.gameObject.SetActive(!roomIconElevator.gameObject.activeInHierarchy);
        roomIconLab.gameObject.SetActive(!roomIconLab.gameObject.activeInHierarchy);
    }
    public void ChangedRoom()
    {
        mapScreen.gameObject.SetActive(!mapScreen.gameObject.activeInHierarchy);
        roomIconStart.gameObject.SetActive(!roomIconStart.gameObject.activeInHierarchy);
        roomIconHall1.gameObject.SetActive(!roomIconHall1.gameObject.activeInHierarchy);
        roomIconHall2.gameObject.SetActive(!roomIconHall2.gameObject.activeInHierarchy);
        roomIconHall3.gameObject.SetActive(!roomIconHall3.gameObject.activeInHierarchy);
        roomIconLocker.gameObject.SetActive(!roomIconLocker.gameObject.activeInHierarchy);
        roomIconLight.gameObject.SetActive(!roomIconLight.gameObject.activeInHierarchy);
        roomIconBreaker.gameObject.SetActive(!roomIconBreaker.gameObject.activeInHierarchy);
        roomIconDirty.gameObject.SetActive(!roomIconDirty.gameObject.activeInHierarchy);
        roomIconDan.gameObject.SetActive(!roomIconDan.gameObject.activeInHierarchy);
        roomIconMary.gameObject.SetActive(!roomIconMary.gameObject.activeInHierarchy);
        roomIconElevator.gameObject.SetActive(!roomIconElevator.gameObject.activeInHierarchy);
        roomIconLab.gameObject.SetActive(!roomIconLab.gameObject.activeInHierarchy);
    }
}
