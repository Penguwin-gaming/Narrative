using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dan : MonoBehaviour
{
    public GameTracker tracker;
    public SpriteRenderer sr;
    public GameObject room;
    public bool isInTheRoom;
    public bool isTalking;
    public TextMeshProUGUI danDialouge;
    public TextMeshProUGUI danDialouge2;
    public TextMeshProUGUI danDialouge3;
    public TextMeshProUGUI danDialouge4;
    public TextMeshProUGUI danDialouge5;
    public TextMeshProUGUI danOption1;
    public TextMeshProUGUI danOption2;
    public TextMeshProUGUI danOption3;
    public TextMeshProUGUI danOption4;
    public TextMeshProUGUI danOption5;
    public TextMeshProUGUI danOption6;

    // Start is called before the first frame update
    void Start()
    {
        tracker.hasDan = false;
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
                StartDialouge();
                isTalking = true;
                sr.GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    public void StartDialouge()
    {
        danDialouge.gameObject.SetActive(true);
        danOption1.gameObject.SetActive(true);
        danOption2.gameObject.SetActive(true);
    }
    public void  StartDialouge2()
    {
        Destroy(danDialouge);
        Destroy(danOption1);
        Destroy(danOption2);
        danDialouge2.gameObject.SetActive(true);
    }
    public void StartDialouge3()
    {
        Destroy(danDialouge);
        Destroy(danOption1);
        Destroy(danOption2);
        danDialouge3.gameObject.SetActive(true);
        danOption3.gameObject.SetActive(true);
        danOption4.gameObject.SetActive(true);
    }
    public void StartDialouge4()
    {
        Destroy(danDialouge3);
        Destroy(danOption3);
        Destroy(danOption4);
        danDialouge4.gameObject.SetActive(true);
    }
    public void StartDialouge5()
    {
        Destroy(danDialouge3);
        Destroy(danOption3);
        Destroy(danOption4);
        danDialouge5.gameObject.SetActive(true);
        danOption5.gameObject.SetActive(true);
        danOption6.gameObject.SetActive(true);
    }
    public void gainsDan()
    {
        Destroy(danDialouge5);
        Destroy(danOption5);
        Destroy(danOption6);
        tracker.hasDan = true;
        Destroy(gameObject, 0.5f);
    }

    public void LosesDan()
    {
        Destroy(gameObject);
        Destroy(danDialouge);
        Destroy(danOption1);
        Destroy(danOption2);
        Destroy(danDialouge2);
        Destroy(danOption3);
        Destroy(danOption4);
        Destroy(danDialouge3);
        Destroy(danOption5);
        Destroy(danOption6);
        Destroy(danDialouge4);
        Destroy(danDialouge5);
        Destroy(gameObject, 0.5f);
    }
}
