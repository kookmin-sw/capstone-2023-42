using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterHPslider : MonoBehaviour
{
    public int nowHp;
    public int maxHp;
    public Image nowHpbar;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 100;
        nowHp = 100;
        nowHpbar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        nowHp = MonsterAttack.instance.MonsterHP;
        nowHpbar.fillAmount = (float)nowHp / (float)maxHp;
    }
}
