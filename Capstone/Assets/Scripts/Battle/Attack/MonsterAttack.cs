using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAttack : MonoBehaviour
{
    public static MonsterAttack instance;
    public int MonsterHP = 100;
    public int mflag = 0;

    void Awake()
    {
        instance = this;
    }

    public void MAttack()
    {        
        if(mflag == 0)
        {
            RandomDice.instance.Roll();
            PlayerAttack.instance.PlayerHP -= (30 + RandomDice.instance.result * 10);
            Debug.Log("Monster Attack");
            if (PlayerAttack.instance.PlayerHP <= 0)
            {
                PlayerAttack.instance.PlayerHP = 0;
                Debug.Log("Player is dead");
                //end
                mflag = 1;
                //GameOver·Î ÀÌµ¿
                SceneManager.LoadScene("GameOver");
            }
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
