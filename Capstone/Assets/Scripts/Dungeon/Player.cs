using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : Character
{
    public static Player instance;
    public List<Enemy> enemyList = new List<Enemy>();
    public AudioSource audioSource;
    public GameObject playerTurnInfo;
    public GameObject enemyTurnInfo;
    public GameObject battleCan;
    public GameObject MonsterObj;
    public MonsterAttack MASC;

    private void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
        battleCan = GameObject.Find("Battle Canvas");
        MonsterObj = GameObject.Find("Monster");
        MASC = MonsterObj.GetComponent<MonsterAttack>();
    }

    void Update()
    {
        if(state == State.playerTurn)
        {
            playerTurnInfo.SetActive(true);
            enemyTurnInfo.SetActive(false);
            moveRatio = 0f;
            MoveStart(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        if (state == State.moving)
        {
            Move();
        }
        StartCoroutine(ChangeTurn());
    }

    protected override void Move()
    {
        if(direction.x < 0)
        {
            transform.right = new Vector3(-1,0,0);
        }
        else if(direction.x > 0)
        {
            transform.right = new Vector3(1,0,0);
        }
        base.Move();
        transform.position = new Vector3(transform.position.x,transform.position.y, -1);
    }

    public IEnumerator ChangeTurn()
    {
        yield return new WaitForSeconds(2f);
        if(state == State.moveFinish)
        {
            state = State.enemyTurn;
            for(int i=0; i<enemyList.Count; i++)
            {
                enemyList[i].state = State.enemyTurn;
            }
            playerTurnInfo.SetActive(false);
            enemyTurnInfo.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            setup(other.gameObject);
            GameObject Battle = battleCan.transform.Find("BackGroundImage").gameObject;
            audioSource.Stop();
            other.gameObject.GetComponent<AudioSource>().Play();
            Battle.SetActive(true);
        }
    }

    public void setup(GameObject Enemy){
        MASC.EnemyObj = Enemy;
        MASC.EnemySC = Enemy.GetComponent<Enemy>();
    }

    [Header("Prop data:")]
    public int HP = 0;
    public int Attack = 0;
    public int SP = 0;
}
