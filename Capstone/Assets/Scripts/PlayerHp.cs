using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHp : MonoBehaviour
{
    //public TMP_Text HP;
    TextMeshProUGUI HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        //스크립트 담을변수이름 = GameObject.Find("스크립트포함한오브젝트이름").GetComponent<스크립트이름>();
        //담은변수.가져올변수명 으로 사용
        RandomDice Instance = GameObject.Find("Dice").GetComponent<RandomDice>();
        HP.text = Instance.PlayerHP.ToString();
        //HP.text = "Player HP";
    }
}
