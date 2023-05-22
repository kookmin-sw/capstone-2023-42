using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHPslider : MonoBehaviour
{
    public int nowHp;
    public int maxHp;
    public Image nowHpbar;
    public MonsterAttack MASC;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 100;
        nowHp = 100;
        nowHpbar = GetComponent<Image>();
        MASC = GameObject.Find("Monster").GetComponent<MonsterAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        nowHp = MASC.EnemySC.hp;
        nowHpbar.fillAmount = (float)nowHp / (float)maxHp;
    }
}
