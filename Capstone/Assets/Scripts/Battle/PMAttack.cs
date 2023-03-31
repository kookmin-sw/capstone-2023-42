using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMAttack : MonoBehaviour
{
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            PlayerAttack.instance.PAttack();
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            MonsterAttack.instance.MAttack();
        }
        /*
            if (flag == 1)
            {
                Application.Quit();
            }
        */
    }
}
