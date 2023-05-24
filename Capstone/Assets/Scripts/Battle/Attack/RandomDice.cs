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
        r = Random.Range(1, 7);
        result = r;
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
