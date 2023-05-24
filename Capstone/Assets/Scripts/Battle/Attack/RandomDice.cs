using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDice : MonoBehaviour
{
    public static RandomDice instance;
    public Image playerDice;
    public Image monsterDice;
    public Text resultText;
    int r;
    public int result;


    void Awake()
    {
        instance = this;
    }
    private void Start() {
    }

    public void Roll()
    {
        if (MonsterAttack.instance.EnemySC.hp > 0 && PlayerAttack.instance.PlayerSC.HP > 0)
        {
            r = Random.Range(1, 7);
            result = r;
        }
    }

    public void PAttack()
    {
        MonsterAttack.instance.EnemySC.hp -= (result * 10);
        PlayerAttack.instance.attackSound.Play();
        StartCoroutine(MonsterAnimation.instance.ChangeColor());

        playerDice.sprite = Resources.Load<Sprite>("Dice/diceGreen" + result.ToString());
        resultText.text = result.ToString();
    }

    public void EAttack()
    {
        MonsterAttack.instance.attackSound.Play();
        PlayerAttack.instance.PlayerSC.HP -= (result * 10);
        StartCoroutine(MonsterAnimation.instance.ChangeSize());
        
        monsterDice.sprite = Resources.Load<Sprite>("Dice/diceRed" + result.ToString());
        resultText.text = result.ToString();
    }
}
