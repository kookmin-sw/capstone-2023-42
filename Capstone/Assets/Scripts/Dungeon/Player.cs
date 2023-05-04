using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    void Update()
    {
        Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log(other.gameObject.name);
    }
}
