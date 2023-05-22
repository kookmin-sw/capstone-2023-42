using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
    [SerializeField] public int PlayerHP = 100;
    [SerializeField] public int PlayerSP = 100;
    public int AttackAmount = 10;
    public int HealAmount = 30;
    //public int itemType = 0; // 0: weapon, 1: healPotion, 2: skillPotion
    public int pflag = 0; // Player가 공격을 했는지 체크
    int p;

    void Awake()
    {
        instance = this;
    }

    public void PAttack()
    {
        pflag = 0;
        Debug.Log("ItemType is " + ItemProp.instance.itemType);
        if (ItemProp.instance.itemType == 0)
        {
            //남은 sp랑 공격에 필요한 sp비교해서 공격이 가능한지 판단
            //PlayerSP -= attackSP;
            PlayerSP -= 30;
            if (PlayerSP <= 0)
            {
                Debug.Log("SP is not enough");
                //PlayerSP += attackSP;
                PlayerSP += 30;
            }
            else
            {
                RandomDice.instance.Roll();
                MonsterAttack.instance.MonsterHP -= (30 + RandomDice.instance.result * AttackAmount);
                Debug.Log("AttackAmount is " + AttackAmount);
                Debug.Log("Player Attack");
                pflag = 1;
                if (MonsterAttack.instance.MonsterHP <= 0)
                {
                    MonsterAttack.instance.MonsterHP = 0;
                    Debug.Log("Monster is dead");
                    //맵으로 이동
                    SceneManager.LoadScene("MainScene");
                }

                Debug.Log("Monster's HP is " + MonsterAttack.instance.MonsterHP);
            }
        }
        else if(ItemProp.instance.itemType == 1)
        {
            p = PlayerHP + HealAmount;
            if (p > 100)
            {
                PlayerHP = 100;
            }
            else
            {
                PlayerHP = p;
            }
            pflag = 1;
        }
        else if (ItemProp.instance.itemType == 2)
        {
            p = PlayerSP + HealAmount;
            if (p > 100)
            {
                PlayerSP = 100;
            }
            else
            {
                PlayerSP = p;
            }
            pflag = 1;
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
