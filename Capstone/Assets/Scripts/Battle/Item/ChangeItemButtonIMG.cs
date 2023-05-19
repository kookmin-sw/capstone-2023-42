using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeItemButtonIMG : MonoBehaviour
{
    Image current;
    [SerializeField] int index;

    // Start is called before the first frame update
    void Start()
    {
        current = GetComponent<Image>();
    }

    public void ChangeImg()
    {
        current.sprite = ItemProp.instance.Itemdata[index].PropSprite;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeImg();
    }
}
