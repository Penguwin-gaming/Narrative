using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LorePaper : MonoBehaviour
{
    public SpriteRenderer sr;
    public GameObject lore;

    // Start is called before the first frame update
    void Start()
    {
        lore.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lore.SetActive(false);
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (sr.bounds.Contains(mousePos))
            {
                lore.SetActive(true);
            }
        }
    }
}
