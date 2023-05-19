using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : Character
{
    public static Player instance;
    public bool playerTurn = true;
    public List<Enemy> enemyList = new List<Enemy>();

    // [SerializeField]
    // private GameObject Battle;
    private GameObject battleCan;

    private void Awake()
    {
        instance = this;
        battleCan = GameObject.Find("Battle Canvas");
    }
    void Update()
    {
        if (playerTurn)
        {
            Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }

        if (state == State.moveStart && playerTurn)
        {
            ChangeTurn();
        }

        if (CheckEnemyTurnFinish())
        {
            playerTurn = true;
        }
    }

    protected override void Move(float x, float y)
    {
        base.Move(x, y);
    }

    public bool CheckEnemyTurnFinish()
    {
        bool enemyTurnFinish = true;
        for (int i = 0; i < enemyList.Count; i++)
        {
            if (enemyList[i].state != State.moveFinish)
            {
                enemyTurnFinish = false;
            }
        }

        return enemyTurnFinish;
    }

    public void ChangeTurn()
    {
        playerTurn = !playerTurn;
        for (int i = 0; i < enemyList.Count; i++)
        {
            enemyList[i].enemyTurn = !enemyList[i].enemyTurn;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Enemy")) {
            // GameObject Battle = GameObject.FindWithTag("Battle");
            GameObject Battle = battleCan.transform.Find("BackGroundImage").gameObject;
            Battle.SetActive(true);
            // SceneManager.LoadScene("Battle");
        }
    }

    [Header("Prop data:")]
    public int HP = 0;
    public int Atack = 0;
}
