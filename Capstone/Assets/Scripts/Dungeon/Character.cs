using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool canMove = true;
    public Vector2 direction;
    public Vector2 dest;
    public float movePixel = 1f;
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
            }


            Vector2 next = transform.position + new Vector3(x, y, 0);
            RaycastHit2D cantGo = Physics2D.Raycast(next, next);
            if (cantGo)
            {
                Debug.Log(cantGo.transform.gameObject.name + ": " + gameObject.name);
            }
        }
        else if (moveRatio < 1f)
        {
            rb.MovePosition(Vector3.Lerp(transform.position, dest, moveRatio));
            moveRatio += moveSpeedPerFrame;
        }

        if (rb.position == dest || moveRatio >= 1f)
        {
            moveRatio = 0f;
            transform.position = new Vector2(Mathf.Round(transform.position.x * 10) * 0.1f, Mathf.Round(transform.position.y * 10) * 0.1f);
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
