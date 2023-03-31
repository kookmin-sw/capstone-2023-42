using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomDice : MonoBehaviour
{
    public static RandomDice instance;
    public int result;
    int flag = 0;

    void Awake()
    {
        instance = this;
    }

    public void Roll()
    {
        //-2 -1 0 1 2 3
        result = Random.Range(-2, 4);
        Debug.Log(result);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
             
    }
}
