using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomDice : MonoBehaviour
{
    public int result;
    public int PlayerHP = 100;
    public int MonsterHP = 100;
    int flag = 0;

    private void Roll()
    {
        //-2 -1 0 1 2 3
        result = Random.Range(-2, 4);
        Debug.Log(result);
    }

    private void PlayerAttack()
    {
        if(PlayerHP <= 0)
        {
            Debug.Log("Player is dead");
            //end
            flag = 1;
        }
        else
        {
            Roll();
            MonsterHP -= (30 + result * 10);
            Debug.Log("Player Attack");
            Debug.Log("Monster's HP is " + MonsterHP);
        }
        
    }

    private void MonsterAttack()
    {
        if(MonsterHP <= 0)
        {
            Debug.Log("Monster is dead");
            //end
            flag = 1;
        }
        else
        {
            Roll();
            PlayerHP -= (10 + result * 5);
            Debug.Log("Monster Attack");
            Debug.Log("Player's HP is " + PlayerHP);
        }
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayerAttack();
            MonsterAttack();
            if(flag == 1)
            {
                Application.Quit();
            }
        }            
    }
}
