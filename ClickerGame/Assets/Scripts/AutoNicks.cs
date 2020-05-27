using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoNicks : MonoBehaviour
{
    public bool CreatingNick = false;
    public static int NickIncrease = 1;
    public int InternalIncrease;

    // Update is called once per frame
    void Update()
    {
        NickIncrease = GlobalAutoNicks.nicksPerSec;
        InternalIncrease = NickIncrease;
        if (CreatingNick == false)
        {
            CreatingNick = true;
            StartCoroutine(CreateTheNick());
        }
    }

    IEnumerator CreateTheNick ()
    {
        GlobalNicks.NickCount += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingNick = false;
    }
}
