using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
    [SerializeField] public int PlayerHP = 100;
    [SerializeField] public int PlayerSP = 50;
    public int pflag = 0;

    void Awake()
    {
        instance = this;
    }

    public void PAttack()
    {
        if(pflag == 0)
        {
            //���� sp�� ���ݿ� �ʿ��� sp���ؼ� ������ �������� �Ǵ�
            //PlayerSP-=attackSP;
            if (PlayerSP <= 0)
            {
                Debug.Log("SP is not enough");
                //PlayerSP+=attackSP;
            }
            else
            {
                RandomDice.instance.Roll();
                MonsterAttack.instance.MonsterHP -= (30 + RandomDice.instance.result * 10);
                Debug.Log("Player Attack");
                if (MonsterAttack.instance.MonsterHP <= 0)
                {
                    MonsterAttack.instance.MonsterHP = 0;
                    Debug.Log("Monster is dead");
                    //end
                    pflag = 1;
                }

                Debug.Log("Monster's HP is " + MonsterAttack.instance.MonsterHP);
            }
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
