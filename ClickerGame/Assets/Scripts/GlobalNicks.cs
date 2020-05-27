using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalNicks : MonoBehaviour
{
    public static int NickCount;
    public Text NickDisplay;
    public int InternalNick;

    void Update()
    {
        InternalNick = NickCount;
        NickDisplay.text = "Nicks: " + InternalNick;
    }
}
