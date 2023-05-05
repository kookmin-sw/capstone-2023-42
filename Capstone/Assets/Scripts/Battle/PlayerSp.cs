using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSp : MonoBehaviour
{
    Text SP;

    // Start is called before the first frame update
    void Start()
    {
        SP = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //스크립트 담을변수이름 = GameObject.Find("스크립트포함한오브젝트이름").GetComponent<스크립트이름>();
        //담은변수.가져올변수명 으로 사용
        PlayerAttack Instance = GameObject.Find("Player").GetComponent<PlayerAttack>();
        SP.text = Instance.PlayerSP.ToString();
    }
}
