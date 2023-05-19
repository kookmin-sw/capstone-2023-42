using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MonsterHp : MonoBehaviour
{
    Text MHP;

    // Start is called before the first frame update
    void Start()
    {
        MHP = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //MonsterAttack Instance = GameObject.Find("Monster").GetComponent<MonsterAttack>();
        //MHP.text = Instance.MonsterHP.ToString();
        MHP.text = MonsterAttack.instance.MonsterHP.ToString();
    }
}
