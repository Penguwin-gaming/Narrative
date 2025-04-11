using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Mary : MonoBehaviour
{
    public GameTracker tracker;
    public SpriteRenderer sr;
    public GameObject room;
    public bool isInTheRoom;
    public bool isTalking;
    public TextMeshProUGUI MaryDialouge;
    public TextMeshProUGUI MaryDialouge2;
    public TextMeshProUGUI MaryOption1;
    public TextMeshProUGUI MaryOption2;
    public TextMeshProUGUI MaryOption3;
    public TextMeshProUGUI MaryOption4;

    // Start is called before the first frame update
    void Start()
    {
        tracker.hasMary = false;
        isInTheRoom = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (room.gameObject.activeInHierarchy == true)
        {
            isInTheRoom = true;
            sr.GetComponent<SpriteRenderer>().enabled = true;
        }
        else if (room.gameObject.activeInHierarchy == false)
        {
            isInTheRoom = false;
            sr.GetComponent<SpriteRenderer>().enabled = false;
        }
        if (Input.GetMouseButtonDown(0) && isInTheRoom == true && isTalking == false)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                StartQuest();
                isTalking = true;
                sr.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    public void StartQuest()
    {
        MaryDialouge.gameObject.SetActive(true);
        MaryOption1.gameObject.SetActive(true);
        if(tracker.hasMedkit == true)
        {
            MaryOption2.gameObject.SetActive(true);
        }
    }

    public void Search()
    {
        isTalking = false; 
        sr.GetComponent <SpriteRenderer>().enabled = true;
        MaryDialouge.gameObject.SetActive(false);
        MaryOption1.gameObject.SetActive(false);
        MaryOption2.gameObject.SetActive(false);
    }

    public void StartDialouge2()
    {
        Destroy(MaryDialouge);
        Destroy(MaryOption1);
        Destroy(MaryOption2);
        MaryDialouge2.gameObject.SetActive(true);
        MaryOption3.gameObject.SetActive(true);
        MaryOption4.gameObject.SetActive(true);
    }
    public void gainsMary()
    {
        Destroy(MaryDialouge2);
        Destroy(MaryOption3);
        Destroy(MaryOption4);
        tracker.hasMary = true;
        Destroy(gameObject, 0.5f);
    }

    public void LosesMary()
    {
        Destroy(gameObject);
        Destroy(MaryDialouge2);
        Destroy(MaryOption3);
        Destroy(MaryOption4);
        Destroy(gameObject, 0.5f);
    }
}
