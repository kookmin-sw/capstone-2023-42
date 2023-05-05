using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PMAttack : MonoBehaviour
{
    public static PMAttack instance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        instance = this;
    }

    IEnumerator twoStep()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        PlayerAttack.instance.PAttack();
        yield return new WaitForSeconds(1);
        MonsterAttack.instance.MAttack();
        yield return new WaitForSeconds(1);
        AttackButton.instance.AButton = 0;
    }

    public void Attack()
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
            //pflag(PlayerAttack으로 Monster가 죽음)와 mflag(MonsterAttack으로 Player가 죽음)
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
        
    }
}
