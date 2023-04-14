using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool canMove = true;
    public Vector2 direction;
    public Vector2 dest;
    public float movePixel = 3f;
    public float moveRatio = 0f;
    public float moveSpeedPerFrame = 0.001f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    protected void Move(float x, float y)
    {
        if (!canMove)
            return;

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
            }
        }
        else if (moveRatio < 1f)
        {
            rb.MovePosition(Vector3.Lerp(transform.position, dest, moveRatio));
            moveRatio += moveSpeedPerFrame;
        }

        if (rb.position == dest)
        {
            moveRatio = 0f;
            transform.position = new Vector2(Mathf.Round(transform.position.x), Mathf.Round(transform.position.y));
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
