using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public static Enemy instance;
    bool isTurn = false;
    private void Awake()
    {
        instance = this;
    }
    void Update()
    {
        if (state == State.enemyTurn)
        {
            float x = Random.Range(-1, 2);
            float y = Random.Range(-1, 2);
            MoveStart(x, y);
        }
        if (state == State.moving)
        {
            Move();
        }

        if (state == State.moveFinish)
        {
            StartCoroutine(ChangeTurn());
        }

        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    protected override void Move()
    {
        if (!isTurn && direction.x < 0)
        {
            transform.right = new Vector3(-1, 0, 0);
            isTurn = true;
        }
        else if (!isTurn && direction.x > 0)
        {
            transform.right = new Vector3(1, 0, 0);
            isTurn = true;
        }
        base.Move();
    }

    public IEnumerator ChangeTurn()
    {
        state = State.playerTurn;
        yield return new WaitForSeconds(1f);
        if(Player.instance.state != State.playerTurn || Player.instance.state != State.moving)
        {
            Player.instance.state = State.playerTurn;
        }
        isTurn = false;

    }

    [Header("Info")]
    public string enemyName;
    public int hp;
    public int minDamage;
    public int maxDamage;

}
