using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MonsterHp : MonoBehaviour
{
    TextMeshProUGUI HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomDice Instance = GameObject.Find("Dice").GetComponent<RandomDice>();
        HP.text = Instance.MonsterHP.ToString();
    }
}
