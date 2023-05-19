using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
<<<<<<< HEAD
    [SerializeField] public int PlayerHP = 100;
    [SerializeField] public int PlayerSP = 100;
    public int AttackAmount = 10;
    public int HealAmount = 30;
    //public int itemType = 0; // 0: weapon, 1: healPotion, 2: skillPotion
    public int pflag = 0; // Player°¡ °ø°ÝÀ» Çß´ÂÁö Ã¼Å©
    int p;
=======
    // [SerializeField] public int PlayerHP = 100;
    // [SerializeField] public int PlayerSP = 50;
    public int PlayerHP;
    public int PlayerSP;

    public GameObject PlayerObj;
    public Player PlayerCS;
    public Enemy OriginEnemy;

    public int pflag = 0;
>>>>>>> JiHun

    public GameObject win;
    private bool isSetupComplete = false;
    

    void Awake()
    {
        instance = this;
        // PlayerObj = GameObject.Find("Player_Test");
        // PlayerCS = PlayerObj.GetComponent<Player>();

        // PlayerHP = PlayerCS.HP;
        // PlayerSP = PlayerCS.SP;
    }

    public void PAttack()
    {
        pflag = 0;
        Debug.Log("ItemType is " + ItemProp.instance.itemType);
        if (ItemProp.instance.itemType == 0)
        {
<<<<<<< HEAD
            //³²Àº sp¶û °ø°Ý¿¡ ÇÊ¿äÇÑ spºñ±³ÇØ¼­ °ø°ÝÀÌ °¡´ÉÇÑÁö ÆÇ´Ü
            //PlayerSP -= attackSP;
            PlayerSP -= 30;
=======
            //ï¿½ï¿½ï¿½ï¿½ spï¿½ï¿½ ï¿½ï¿½ï¿½Ý¿ï¿½ ï¿½Ê¿ï¿½ï¿½ï¿½ spï¿½ï¿½ï¿½Ø¼ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½Ç´ï¿½
            //PlayerSP-=attackSP;
>>>>>>> JiHun
            if (PlayerSP <= 0)
            {
                Debug.Log("SP is not enough");
                //PlayerSP += attackSP;
                PlayerSP += 30;
            }
            else
            {
                RandomDice.instance.Roll();
<<<<<<< HEAD
                MonsterAttack.instance.MonsterHP -= (30 + RandomDice.instance.result * AttackAmount);
                Debug.Log("AttackAmount is " + AttackAmount);
                Debug.Log("Player Attack");
                pflag = 1;
                if (MonsterAttack.instance.MonsterHP <= 0)
=======
                OriginEnemy.hp -= (30 + RandomDice.instance.result * 10);
                // MonsterAttack.instance.setMonsterHP();
                Debug.Log("Player Attack");
                if (OriginEnemy.hp <= 0)
>>>>>>> JiHun
                {
                    OriginEnemy.hp = 0;
                    Debug.Log("Monster is dead");
<<<<<<< HEAD
                    //¸ÊÀ¸·Î ÀÌµ¿
                    SceneManager.LoadScene("MainScene");
=======
                    //end
                    pflag = 1;
                    //ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½Ìµï¿½
                    // SceneManager.LoadScene("BackGround_Test");
                    win.SetActive(false);
>>>>>>> JiHun
                }

                Debug.Log("Monster's HP is " + OriginEnemy.hp);
                
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
        Invoke("setup", 5.0f);
    }

    void setup(){
        PlayerObj = GameObject.Find("Player_Test(Clone)");
        PlayerCS = PlayerObj.GetComponent<Player>();

        PlayerHP = PlayerCS.HP;
        PlayerSP = PlayerCS.SP;
        isSetupComplete = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSetupComplete)
        {
            PlayerHP = PlayerCS.HP;
            PlayerSP = PlayerCS.SP;
        }
    }
}
