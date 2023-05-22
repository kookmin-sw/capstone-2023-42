// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class ChangeIIMG : MonoBehaviour
// {
//     //inventory���� ������ item�� ���� Prop���� ��������Ʈ�� �޾ƿ;� ��   
//     Image current;

//     // Start is called before the first frame update
//     void Start()
//     {
//         current = GetComponent<Image>();
//     }

//     void Change()
//     {
//         current.sprite = ItemProp.instance.Itemdata[Item.instance.selectItem].PropSprite;
//     }

//     void check()
//     {
//         if(Item.instance.selectItem != -1)
//         {
//             Change();
//         }
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         check();
//     }
// }
