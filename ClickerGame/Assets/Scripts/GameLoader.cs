using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoader : MonoBehaviour
{
    public int savedNicks;
    public int savedAutoNicks;
    public int savedNicksPerSec;

    // Start is called before the first frame update
    void Start()
    {
        if(MainMenu.isLoading == true)
        {
            savedNicks = PlayerPrefs.GetInt("SavedNicks");
            GlobalNicks.NickCount = savedNicks;

            savedAutoNicks = PlayerPrefs.GetInt("NumberOfAutoNicks");
            GlobalAutoNicks.numberOfNicks = savedAutoNicks;

            savedNicksPerSec = PlayerPrefs.GetInt("NicksPerSec");
            GlobalAutoNicks.nicksPerSec = savedNicksPerSec;
        }
    }
}
