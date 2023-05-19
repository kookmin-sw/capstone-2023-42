using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public Prop item;
    public int itemCount;
    public Sprite itemImage;

    // [SerializeField]
    // private Text text_Count;
    // [SerializeField]
    // private GameObject go_CountImage;

    private void SetColor(float _alpha)
    {
        // Color color = itemImage.color;
        // color.a = _alpha;
        // itemImage.color = color;
    }

    public void AddItem(Prop _item, int _count = 1)
    {
        item = _item;
        itemCount = _count;
        itemImage = item.PropSprite;

        Image itemImageComponent = GetComponent<Image>();
        if (itemImageComponent != null)
        {
            itemImageComponent.sprite = itemImage;

            Color imageColor = itemImageComponent.color;
            imageColor.a = 1f;
            itemImageComponent.color = imageColor;
        }

        // if(item.weapon != true)
        // {
        //     go_CountImage.SetActive(true);
        //     text_Count.text = itemCount.ToString();
        // }
        // else
        // {
        //     text_Count.text = "0";
        //     go_CountImage.SetActive(false);
        // }

        SetColor(1);
    }

    public void SetSlotCount(int _count)
    {
        itemCount += _count;
        // text_Count.text = itemCount.ToString();

        if (itemCount <= 0)
            ClearSlot();
    }

    
    public void ClearSlot()
    {
        item = null;
        itemCount = 0;
        itemImage = null;
        SetColor(0);

        Image itemImageComponent = GetComponent<Image>();
        if (itemImageComponent != null)
        {
            // Source Image를 null로 설정하여 이미지가 표시되지 않도록 함
            itemImageComponent.sprite = null;
            Color imageColor = itemImageComponent.color;
            imageColor.a = 0f;
            itemImageComponent.color = imageColor;
        }

        // text_Count.text = "0";
        // go_CountImage.SetActive(false);
    }
}
