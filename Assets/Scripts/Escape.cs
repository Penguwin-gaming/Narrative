using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Escape : MonoBehaviour
{
    public GameTracker tracker;
    public SpriteRenderer sr;
    public GameObject room;
    public bool isInTheRoom;
    public GameObject endScreen;
    public TextMeshProUGUI Dan;
    public TextMeshProUGUI Mary;
    public TextMeshProUGUI Cure;
    public bool timerActive;
    public float timer;
    public GameObject text;
    public Button map;

    // Start is called before the first frame update
    void Start()
    {
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
        if (Input.GetMouseButtonDown(0) && isInTheRoom == true && tracker.canEscape)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                GameObject screen = Instantiate(endScreen);
                screen.transform.position = new Vector3(0f, 0f, 0f);
                timerActive = true;
                map.gameObject.SetActive(false);
            }
        }

        if (tracker.hasDan == true)
        {
            Dan.text = "With Dan";
        }
        if (tracker.hasMary == true)
        {
            Mary.text = "With Mary";
        }
        if (tracker.hasCure == true)
        {
            Cure.text = "With the cure";
        }
        if (timerActive == true)
        {
            timer += Time.deltaTime;
        }
        if (timer > 5)
        {
            text.SetActive(true);
        }
    }
}
