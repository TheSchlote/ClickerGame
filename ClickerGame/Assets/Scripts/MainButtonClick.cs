using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonClick : MonoBehaviour
{
    public Button NickButton;

    public Sprite nick1;
    public Sprite nick2;
    public Sprite nick3;
    public Sprite nick4;
    public Sprite nick5;
    public Sprite nick6;
    public Sprite nick7;
    public Sprite nick8;
    public Sprite nick9;
    public Sprite nick10;
    public Sprite nick11;
    public Sprite nick12;
    public Sprite nick13;
    public Sprite nick14;
    public Sprite nick15;
    public Sprite nick16;
    public Sprite nick17;
    public Sprite nick18;
    public Sprite nick19;
    public Sprite nick20;

    public void ClickTheButton()
    {
        GlobalNicks.NickCount += 1;
        changeNickButton();
    }

    public void changeNickButton()
    {
        int randomNick = Random.Range(1, 21);
        switch (randomNick) 
        {
            case 1:
                NickButton.image.sprite = nick1;
                break;
            case 2:
                NickButton.image.sprite = nick2;
                break;
            case 3:
                NickButton.image.sprite = nick3;
                break;
            case 4:
                NickButton.image.sprite = nick4;
                break;
            case 5:
                NickButton.image.sprite = nick5;
                break;
            case 6:
                NickButton.image.sprite = nick6;
                break;
            case 7:
                NickButton.image.sprite = nick7;
                break;
            case 8:
                NickButton.image.sprite = nick8;
                break;
            case 9:
                NickButton.image.sprite = nick9;
                break;
            case 10:
                NickButton.image.sprite = nick10;
                break;
            case 11:
                NickButton.image.sprite = nick1;
                break;
            case 12:
                NickButton.image.sprite = nick12;
                break;
            case 13:
                NickButton.image.sprite = nick13;
                break;
            case 14:
                NickButton.image.sprite = nick14;
                break;
            case 15:
                NickButton.image.sprite = nick15;
                break;
            case 16:
                NickButton.image.sprite = nick16;
                break;
            case 17:
                NickButton.image.sprite = nick17;
                break;
            case 18:
                NickButton.image.sprite = nick18;
                break;
            case 19:
                NickButton.image.sprite = nick19;
                break;
            case 20:
                NickButton.image.sprite = nick20;
                break;
        }
    }
}
