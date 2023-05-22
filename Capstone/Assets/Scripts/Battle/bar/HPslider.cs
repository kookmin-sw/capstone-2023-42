using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPslider : MonoBehaviour
{
    public int nowHp;
    public int maxHp;
    public Image nowHpbar;
    public PlayerAttack PASC;

    // Start is called before the first frame update
    void Start()
    {
        maxHp = 100;
        nowHp = 100;
        nowHpbar = GetComponent<Image>();
        PASC = GameObject.Find("Player").GetComponent<PlayerAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        nowHp = PASC.PlayerSC.HP;
        nowHpbar.fillAmount = (float)nowHp / (float)maxHp;
    }
}
