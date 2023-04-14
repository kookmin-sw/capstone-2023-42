using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    void Update()
    {
        float x = Random.Range(-1,2);
        float y = Random.Range(-1,2);
        Move(x,y);
    }
}
