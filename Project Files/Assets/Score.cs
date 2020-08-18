using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount;
    public Text scoretext;

    private void Start()
    {
        PinCount = 0;
    }

    private void Update()
    {
        scoretext.text = PinCount.ToString();
    }

}
