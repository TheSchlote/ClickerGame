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
    public Text statsText;

    public void SaveTheGame()
    {
        PlayerPrefs.SetInt("SavedNicks", GlobalNicks.NickCount);
        PlayerPrefs.SetInt("NumberOfAutoNicks", GlobalAutoNicks.numberOfNicks);
        PlayerPrefs.SetInt("NicksPerSec", GlobalAutoNicks.nicksPerSec);

        statsText.text = "Game saved! - " + GlobalNicks.NickCount + " with Nicks Collected!";
    }
}
