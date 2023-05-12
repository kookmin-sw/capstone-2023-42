using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Result : MonoBehaviour
{
    Text RS;

    // Start is called before the first frame update
    void Start()
    {
        RS = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        RandomDice Instance = GameObject.Find("Dice").GetComponent<RandomDice>();
        RS.text = Instance.result.ToString();
    }
}
