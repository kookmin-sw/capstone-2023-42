using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomDice : MonoBehaviour
{
    public static RandomDice instance;
    int r;
    public int result;
    

    void Awake()
    {
        instance = this;
    }

    public void Roll()
    {
        //-2 -1 0 1 2 3
        r = Random.Range(-2, 4);
        if(r == 0)
        {
            //-3 -2 -1 1 2 3
            result = -3;
        }
        else
        {
            result = r;
        }
        Debug.Log("Result is " + result);
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
