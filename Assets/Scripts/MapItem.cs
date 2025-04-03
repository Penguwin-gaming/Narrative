using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapItem : MonoBehaviour
{
    public SpriteRenderer sr;
    public Button map;
    public GameObject mapPickup;

    // Start is called before the first frame update
    void Start()
    {
        mapPickup.gameObject.SetActive(true);
        map.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                map.gameObject.SetActive(true);
                mapPickup.gameObject.SetActive(false);
            }
        }


    }
}
