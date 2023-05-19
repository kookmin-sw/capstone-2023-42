using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
    // [SerializeField] public int PlayerHP = 100;
    // [SerializeField] public int PlayerSP = 50;
    public int PlayerHP;
    public int PlayerSP;

    public GameObject PlayerObj;
    public Player PlayerCS;
    public Enemy OriginEnemy;

    public int pflag = 0;

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
                OriginEnemy.hp -= (30 + RandomDice.instance.result * 10);
                // MonsterAttack.instance.setMonsterHP();
                Debug.Log("Player Attack");
                if (OriginEnemy.hp <= 0)
                {
                    OriginEnemy.hp = 0;
                    Debug.Log("Monster is dead");
                    //end
                    pflag = 1;
                    //������ �̵�
                    // SceneManager.LoadScene("BackGround_Test");
                    win.SetActive(false);
                }

                Debug.Log("Monster's HP is " + OriginEnemy.hp);
                
            }
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
