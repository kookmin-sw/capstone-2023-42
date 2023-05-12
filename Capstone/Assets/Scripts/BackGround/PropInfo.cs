using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PropInfo : MonoBehaviour
{
    public Prop prop;

    private void Start()
    {
        prop = GetComponent<Prop>();
    }

    // Prop 정보를 사용하는 기능을 추가
}