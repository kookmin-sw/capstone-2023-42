using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMAttack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator twoStep()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerAttack.instance.PAttack();
            yield return new WaitForSeconds(1);
            MonsterAttack.instance.MAttack();
            yield return new WaitForSeconds(1);
        }
    }

    void Attack()
    {
        /*   
           if (Input.GetKeyUp(KeyCode.Space))
           {
               PlayerAttack.instance.PAttack();
               Input.ResetInputAxes();
               if (Input.GetKeyUp(KeyCode.Space))
               {
                   MonsterAttack.instance.MAttack();         
               }

           }
          */
        /*
            //pflag(PlayerAttack���� Monster�� ����)�� mflag(MonsterAttack���� Player�� ����)
            if (PlayerAttack.instance.pflag == 1 ||MonsterAttack.instance.mflag == 1 )
            {
                Application.Quit();
            }
        */

        StartCoroutine(twoStep());

    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
}
