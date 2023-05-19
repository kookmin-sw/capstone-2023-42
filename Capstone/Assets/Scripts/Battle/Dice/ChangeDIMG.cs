using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeDIMG : MonoBehaviour
{
    public Sprite dice1;
    public Sprite dice2;
    public Sprite dice3;
    public Sprite diceM1;
    public Sprite diceM2;
    public Sprite diceM3;
    Image current;

    // Start is called before the first frame update
    void Start()
    {
        current = GetComponent<Image>();
    }

    void Change()
    {
        int r = RandomDice.instance.result;
        if (r == 1)
        {
            current.sprite = dice1;
        }
        else if (r == 2)
        {
            current.sprite = dice2;
        }
        else if (r == 3)
        {
            current.sprite = dice3;
        }
        else if (r == -1)
        {
            current.sprite = diceM1;
        }
        else if (r == -2)
        {
            current.sprite = diceM2;
        }
        else if (r == -3)
        {
            current.sprite = diceM3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Change();
    }
}
