using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public SpriteRenderer sr;
    public float appearChance;

    // Start is called before the first frame update
    void Start()
    {
        appearChance = Random.Range(0, 5);
    }

    // Update is called once per frame
    void Update()
    {

        if (appearChance > 3)
        {
            sr.GetComponent<Renderer>().enabled = true;
        }
    }
}
