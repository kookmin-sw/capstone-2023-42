using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIIMG : MonoBehaviour
{
    //inventory에서 선택한 item에 따라 Prop에서 스프라이트를 받아와야 함   
    Image current;

    // Start is called before the first frame update
    void Start()
    {
        current = GetComponent<Image>();
    }

    void Change()
    {
        current.sprite = ItemProp.instance.Itemdata[Item.instance.selectItem].PropSprite;
    }

    void check()
    {
        if(Item.instance.selectItem != -1)
        {
            Change();
        }
    }

    // Update is called once per frame
    void Update()
    {
        check();
    }
}
