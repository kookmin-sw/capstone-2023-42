using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
    public static PlayerAttack instance;
    [SerializeField] public int PlayerHP = 100;
    [SerializeField] public int PlayerSP = 50;
    public int pflag = 0;
    public GameObject win;
    public GameObject PlayerObj;
    public GameObject LoseImage;
    public Player PlayerSC;
    public GameObject playerDice;
    public AudioSource attackSound;

    void Awake()
    {
        instance = this;
    }

    public void PAttack()
    {
        if (pflag == 0)
        {
            //PlayerSP-=attackSP;
            if (PlayerSP <= 0)
            {
                Debug.Log("SP is not enough");
            }
            else
            {
                MonsterAttack.instance.monsterDice.SetActive(false);
                playerDice.SetActive(true);
                playerDice.GetComponent<Animator>().SetTrigger("Roll");
            }
        }
    }

    void Start()
    {
        Invoke("setup", 3.0f);
        attackSound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (PlayerSC != null)
        {
            if (PlayerSC.HP <= 0)
            {
                PlayerAttack.instance.PlayerSC.HP = 0;
                MonsterAttack.instance.mflag = 1;
                StartCoroutine(MonsterWin());
            }
        }
    }

    void setup()
    {
        PlayerObj = GameObject.FindGameObjectsWithTag("Player")[0];
        PlayerSC = PlayerObj.GetComponent<Player>();
    }

    public IEnumerator MonsterWin()
    {
        yield return new WaitForSeconds(2f);
        LoseImage.SetActive(true);
        yield return new WaitForSeconds(3f);
        LoseImage.SetActive(false);
        SceneManager.LoadScene("GameOver");
    }

    public void Run()
    {
        PlayerSC.HP -= 10;
        Player.instance.monsterFighting.GetComponent<AudioSource>().Stop();
        Player.instance.gameObject.GetComponent<AudioSource>().Play();
    }
}
