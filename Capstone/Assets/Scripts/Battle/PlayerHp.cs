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
        //��ũ��Ʈ ���������̸� = GameObject.Find("��ũ��Ʈ�����ѿ�����Ʈ�̸�").GetComponent<��ũ��Ʈ�̸�>();
        //��������.�����ú����� ���� ���
        PlayerAttack Instance = GameObject.Find("Player").GetComponent<PlayerAttack>();
        HP.text = Instance.PlayerHP.ToString();
        //HP.text = "Player HP";
    }
}
