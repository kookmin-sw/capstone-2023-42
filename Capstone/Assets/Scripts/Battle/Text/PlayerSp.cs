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
        //��ũ��Ʈ ���������̸� = GameObject.Find("��ũ��Ʈ�����ѿ�����Ʈ�̸�").GetComponent<��ũ��Ʈ�̸�>();
        //��������.�����ú����� ���� ���
        PlayerAttack Instance = GameObject.Find("Player").GetComponent<PlayerAttack>();
        SP.text = Instance.PlayerSC.SP.ToString();
    }
}
