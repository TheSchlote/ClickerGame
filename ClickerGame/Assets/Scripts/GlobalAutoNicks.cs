using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAutoNicks : MonoBehaviour
{
    public Button AutoButton;
    public Text txtAutoButton;
    public static int nickValue = 10;
    public Text txtNickStats;
    public static int numberOfNicks;
    public static int nicksPerSec;

    // Update is called once per frame
    void Update()
    {
        txtAutoButton.text = "Buy AutoNick - $" + nickValue;
        txtNickStats.text = "AutoNicking : " + numberOfNicks + " @ " + nicksPerSec + "Nicks Per Second";

        AutoButton.interactable = true;

    }
}
