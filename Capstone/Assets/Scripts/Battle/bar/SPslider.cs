using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SPslider : MonoBehaviour
{
    public int nowSp;
    public int maxSp;
    public Image nowSpbar;

    // Start is called before the first frame update
    void Start()
    {
        maxSp = 100;
        nowSp = 100;
        nowSpbar = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        nowSp = PlayerAttack.instance.PlayerSC.SP;
        nowSpbar.fillAmount = (float)nowSp / (float)maxSp;
    }
}
