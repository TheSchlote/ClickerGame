using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public Button AutoButton;
    public Text txtAutoButton;
    public int currentCash;
    public static int bakerValue = 10;
    public Text txtbakerStats;
    public static int numberOfBakers;
    public static int bakersPerSec;

    // Update is called once per frame
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        txtAutoButton.text = "Buy Baker - $" + bakerValue;
        txtbakerStats.text = "Bakers: " + numberOfBakers + " @ " + bakersPerSec + " Per Second";

        if (currentCash >= bakerValue)
        {
            AutoButton.interactable = true;
        }
        else
        {
            AutoButton.interactable = false;
        }
    }
}
