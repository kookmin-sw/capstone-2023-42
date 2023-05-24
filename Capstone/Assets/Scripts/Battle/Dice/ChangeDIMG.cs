using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDIMG : MonoBehaviour
{
    public static ChangeDIMG instance;
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite diceM1;
    public Sprite diceM2;
    public Sprite diceM3;
    public Text text;

    private void Awake() {
        instance = this;
    }
    public void Change(Image image ,int r)
    {
        if (r == 1)
        {
            image.sprite = dice1;
        }
        else if (r == 2)
        {
            image.sprite = dice2;
        }
        else if (r == 3)
        {
            image.sprite = dice3;
        }
        else if (r == 4)
        {
            image.sprite = diceM1;
        }
        else if (r == 5)
        {
            image.sprite = diceM2;
        }
        else if (r == 6)
        {
            image.sprite = diceM3;
        }
    }
}
