using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedCookies;
    public int savedCash;
    public int savedBakers;
    public int savedBakersPerSec;

    // Start is called before the first frame update
    void Start()
    {
        if(MainMenu.isLoading == true)
        {
            savedCookies = PlayerPrefs.GetInt("SavedCookies");
            GlobalCookies.CookieCount = savedCookies;

            savedCash = PlayerPrefs.GetInt("SavedCash");
            GlobalCash.CashCount = savedCash;

            savedBakers = PlayerPrefs.GetInt("NumberOfBakers");
            GlobalBaker.numberOfBakers = savedBakers;

            savedBakersPerSec = PlayerPrefs.GetInt("BakersPerSec");
            GlobalBaker.bakersPerSec = savedBakersPerSec;
        }
    }
}
