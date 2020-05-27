using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.UI;

public class SaveGame : MonoBehaviour
{
    //public int saveGameCash;
    public Button saveButton;
    public Text saveText;

    void Update()
    {
        
    }

    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedCookies", GlobalCookies.CookieCount);
        PlayerPrefs.SetInt("SavedCash", GlobalCash.CashCount);
        PlayerPrefs.SetInt("NumberOfBakers", GlobalBaker.numberOfBakers);
        PlayerPrefs.SetInt("BakersPerSec", GlobalBaker.bakersPerSec);
    }
}
