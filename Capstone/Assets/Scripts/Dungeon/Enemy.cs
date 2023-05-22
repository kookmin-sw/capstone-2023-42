using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public static Enemy instance;
    public bool enemyTurn = false;
    bool isTurn = false;

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

        if (state == State.moveFinish)
        {
            enemyTurn = false;
            isTurn = false;
        }
        if(hp<=0)
        {
            Destroy(gameObject);
        }
    }

    protected override void Move(float x, float y)
    {
        if (!isTurn && x < 0)
        {
            transform.right = new Vector3(-1, 0, 0);
            isTurn = true;
        }
        else if (!isTurn && x > 0)
        {
            transform.right = new Vector3(1, 0, 0);
            isTurn = true;
        }
        base.Move(x, y);
    }

    [Header("Info")]
    public string enemyName;
    public int hp;
    public int minDamage;
    public int maxDamage;

}
