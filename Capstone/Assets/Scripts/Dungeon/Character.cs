using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 3f;
    public bool canMove = true;
    protected virtual void Move()
    {
        if(!canMove)
            return;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        Vector3 direction = new Vector3(horizontal,vertical).normalized;
        transform.position +=  direction;
        StartCoroutine(moveCoolDown());
    }

    IEnumerator moveCoolDown()
    {
        canMove = false;
        yield return new WaitForSeconds(0.5f);
        canMove = true;
    }
}
