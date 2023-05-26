using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public enum State
    {
        gameStart, playerTurn, enemyTurn, moving, moveFinish
    }
    public State state;
    public Animator animator;
    public Rigidbody2D rb;
    public bool canMove = true;
    public Vector2 direction;
    public Vector2 dest;
    public float movePixel = 1f;
    public float moveRatio = 0f;
    public float moveSpeedPerFrame = 0.001f;

    void Start()
    {
        state = State.playerTurn;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    protected virtual void MoveStart(float x, float y)
    {
        if (!canMove)
            return;

        if (x == 0 && y == 0)
            return;

        if (x != 0 && y != 0)
        {
            y = 0;
        }

        if (moveRatio == 0f)
        {
            if (x != 0 || y != 0)
            {
                direction = new Vector2(x, y) * movePixel;
                if (direction.x != 0)
                {
                    dest = transform.position + Vector3.right * direction.x;
                }
                else
                {
                    dest = transform.position + Vector3.up * direction.y;
                }
                moveRatio += moveSpeedPerFrame;

                state = State.moving;
            }
        }
    }

    protected virtual void Move()
    {
        if (moveRatio < 1f)
        {
            rb.MovePosition(Vector3.Lerp(transform.position, dest, moveRatio));
            moveRatio += moveSpeedPerFrame;
        }

        if (rb.position == dest || moveRatio >= 1f)
        {
            moveRatio = 0f;
            transform.position = new Vector2(Mathf.Floor(transform.position.x) + 0.5f, Mathf.Floor(transform.position.y) + 0.5f);
            state = State.moveFinish;
            StartCoroutine(StopMove());
        }
    }

    IEnumerator StopMove()
    {
        canMove = false;
        yield return new WaitForSeconds(0.5f);
        canMove = true;
    }
}
