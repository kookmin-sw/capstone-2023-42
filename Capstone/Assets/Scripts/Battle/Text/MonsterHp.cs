using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MonsterHp : MonoBehaviour
{
    Text HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        MonsterAttack Instance = GameObject.Find("Monster").GetComponent<MonsterAttack>();
        HP.text = Instance.EnemySC.hp.ToString();
    }
}
