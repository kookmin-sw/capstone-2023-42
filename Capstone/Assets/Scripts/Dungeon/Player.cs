using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    void Update()
    {
        Move(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
}
