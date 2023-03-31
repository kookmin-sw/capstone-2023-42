using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonoBehaviour
{
    public static MonsterAttack instance;
    public int MonsterHP = 100;

    void Awake()
    {
        instance = this;
    }

    public void MAttack()
    {
        if (MonsterHP <= 0)
        {
            Debug.Log("Monster is dead");
            //end
            //flag = 1;
        }
        else
        {
            RandomDice.instance.Roll();
            PlayerAttack.instance.PlayerHP -= (10 + RandomDice.instance.result * 5);
            Debug.Log("Monster Attack");
            Debug.Log("Player's HP is " + PlayerAttack.instance.PlayerHP);
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
