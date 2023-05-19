using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public static Enemy instance;
    public bool enemyTurn = false;

    // public GameObject Battle;

    // public void openBattle(){
    //     Battle.SetActive(true);
    // }

    private void Awake()
    {
        enemyTurn = false;
        instance = this;
    }
    void Update()
    {
        if (enemyTurn)
        {
            float x = Random.Range(-1, 2);
            float y = Random.Range(-1, 2);
            Move(x, y);
        }

        if(state == State.moveFinish)
        {
            enemyTurn = false;
        }
    }

    protected override void Move(float x, float y)
    {
        base.Move(x, y);
    }

    [Header("Info")]
    public string enemyName;
    public int hp;
    public int minDamage;
    public int maxDamage;

}
