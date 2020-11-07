using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public static int numberOfPeople;
    public Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        numberOfPeople = 0;
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = "Number of people in train:" + numberOfPeople;
    }
}
