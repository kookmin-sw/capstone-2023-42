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
        //��ũ��Ʈ ���������̸� = GameObject.Find("��ũ��Ʈ�����ѿ�����Ʈ�̸�").GetComponent<��ũ��Ʈ�̸�>();
        //��������.�����ú����� ���� ���
        PlayerAttack Instance = GameObject.Find("Player").GetComponent<PlayerAttack>();
        HP.text = Instance.PlayerSC.HP.ToString();
        //HP.text = "Player HP";
    }
}
