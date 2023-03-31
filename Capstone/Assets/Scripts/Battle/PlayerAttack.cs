using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
    public int PlayerHP = 100;

    void Awake()
    {
        instance = this;
    }

    public void PAttack()
    {
        if (PlayerHP <= 0)
        {
            Debug.Log("Player is dead");
            //end
            //flag = 1;
        }
        else
        {
            RandomDice.instance.Roll();
            MonsterAttack.instance.MonsterHP -= (30 + RandomDice.instance.result * 10);
            Debug.Log("Player Attack");
            Debug.Log("Monster's HP is " + MonsterAttack.instance.MonsterHP);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
