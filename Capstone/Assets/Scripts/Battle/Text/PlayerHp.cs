using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHp : MonoBehaviour
{
    //public TMP_Text HP;
    Text HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //스크립트 담을변수이름 = GameObject.Find("스크립트포함한오브젝트이름").GetComponent<스크립트이름>();
        //담은변수.가져올변수명 으로 사용
        PlayerAttack Instance = GameObject.Find("Player").GetComponent<PlayerAttack>();
        HP.text = Instance.PlayerHP.ToString();
        //HP.text = "Player HP";
    }
}
