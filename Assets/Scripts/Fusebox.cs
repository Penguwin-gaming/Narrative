using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fusebox : MonoBehaviour
{
    public GameTracker tracker;
    public SpriteRenderer sr;
    public GameObject room;
    public bool isInTheRoom;

    // Start is called before the first frame update
    void Start()
    {
        tracker.powerIsOn = false;
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
        if (Input.GetMouseButtonDown(0) && isInTheRoom == true && tracker.hasFuse == true)
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                tracker.powerIsOn = true;
                Destroy(gameObject, 0.2f);
            }
        }
    }
}
