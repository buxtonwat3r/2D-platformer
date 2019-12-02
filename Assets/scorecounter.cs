using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecounter : MonoBehaviour
{

    Text text;
    public static int coinAmount;

    void Start()
    {
        if(tag != "levelCompleteScore")
        {
            coinAmount = 0;
        }

        text = GetComponent<Text>();
    }

    void Update()
    {
        
        text.text = coinAmount.ToString();
    }

}