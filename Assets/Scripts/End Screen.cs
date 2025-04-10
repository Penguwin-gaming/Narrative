using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Search;
using UnityEngine;

public class EndScreen : MonoBehaviour
{
    public GameObject screen;
    public float timer;
    public GameTracker tracker;
    public TextMeshProUGUI Dan;
    public TextMeshProUGUI Mary;
    public TextMeshProUGUI Cure;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

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

        if (timer > 5)
        {
            screen.SetActive(true);
        }
    }
}
