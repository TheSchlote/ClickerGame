using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoNick;
    public AudioSource playSound;

    public void StartAutoNicks()
    {
        playSound.Play();
        AutoNick.SetActive(true);
        GlobalAutoNicks.nickValue *= 2;
        GlobalAutoNicks.numberOfNicks += 1;
        GlobalAutoNicks.nicksPerSec += 1;
    }
}
