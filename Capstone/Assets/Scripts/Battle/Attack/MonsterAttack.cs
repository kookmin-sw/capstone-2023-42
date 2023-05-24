using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterAttack : MonoBehaviour
{
    public static MonsterAttack instance;
    [SerializeField] public int MonsterHP = 100;
    public int mflag = 0;
    public GameObject WinImage;
    public GameObject EnemyObj;
    public Enemy EnemySC;

    void Awake()
    {
        instance = this;
    }

    public void MAttack()
    {
        if (mflag == 0)
        {
            RandomDice.instance.Roll();
            PlayerAttack.instance.PlayerSC.HP -= (30 + RandomDice.instance.result * 10);
            Debug.Log("Player's HP is " + PlayerAttack.instance.PlayerSC.HP);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        EnemyObj = null;
        EnemySC = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemySC != null)
        {
            if (EnemySC.hp <= 0)
            {
                EnemySC.hp = 0;
                PlayerAttack.instance.pflag = 1;
                StartCoroutine(PlayerWin());
            }
        }
    }

    public IEnumerator PlayerWin()
    {
        WinImage.SetActive(true);
        yield return new WaitForSeconds(3f);
        WinImage.SetActive(false);
        PlayerAttack.instance.pflag = 1;
        PlayerAttack.instance.win.SetActive(false);
        Player.instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
