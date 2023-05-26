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
    public GameObject monsterDice;

    void Awake()
    {
        instance = this;
    }

    public void MAttack()
    {
        if (mflag == 0)
        {
            if (EnemySC.hp > 0)
            {
                monsterDice.SetActive(true);
                monsterDice.GetComponent<Animator>().SetTrigger("Roll");
                PlayerAttack.instance.playerDice.SetActive(false);
            }
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
        yield return new WaitForSeconds(2f);
        WinImage.SetActive(true);
        yield return new WaitForSeconds(3f);
        WinImage.SetActive(false);
        PlayerAttack.instance.pflag = 1;
        PlayerAttack.instance.win.SetActive(false);
        Player.instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
