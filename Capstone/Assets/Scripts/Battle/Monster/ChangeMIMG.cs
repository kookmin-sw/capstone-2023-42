using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMIMG : MonoBehaviour
{
    //monster�� Enemy Prop�� �޾ƿ;� ��
    public Prop monster;
    Image current;

    // Start is called before the first frame update
    void Start()
    {
        current = GetComponent<Image>();
    }

    void Change()
    {
        current.sprite = monster.PropSprite;
    }

    // Update is called once per frame
    void Update()
    {
        //Change();
    }
}
