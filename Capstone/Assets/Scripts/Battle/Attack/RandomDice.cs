using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomDice : MonoBehaviour
{
    public static RandomDice instance;
    public GameObject dice;
    int r;
    public int result;


    void Awake()
    {
        instance = this;
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
        MonsterAttack.instance.EnemySC.hp -= (30 + result * 10);
    }

    public void EAttack()
    {
        PlayerAttack.instance.PlayerSC.HP -= (30 + RandomDice.instance.result * 10);
    }
}
