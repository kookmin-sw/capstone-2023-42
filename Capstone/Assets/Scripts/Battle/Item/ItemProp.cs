// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ItemProp : MonoBehaviour
// {
//     public static ItemProp instance;
//     //Itemdata����Ʈ�� �ϳ��� Prop�� �־ �ǰ�, 
//     //�ƴϸ� ������ 9�� ����� ���� Itemdata����Ʈ�� �� ��ġ�� Prop�� �־ ��
//     [SerializeField] public List<Prop> Itemdata = new List<Prop>(9);
//     //Itemdata.Add(�߰��� Prop����);
//     int ind = Item.instance.selectItem;
//     public int itemType = 0; // 0: weapon, 1: healPotion, 2: skillPotion

//     void Awake()
//     {
//         instance = this;
//     }

//     public void SetItemType()
//     {
//         if (Itemdata[ind].weapon == true)
//         {
//             itemType = 0;
//         }
//         else if (Itemdata[ind].healPotion == true)
//         {
//             itemType = 1;
//         }
//         else if (Itemdata[ind].skillPotion == true)
//         {
//             itemType = 2;
//         }
//     }

//     public void SetAttackAmount(int type)
//     {
//         if(type == 0)
//         {
//             PlayerAttack.instance.AttackAmount = Itemdata[ind].weaponDamage;
//         }
//         else if(type == 1)
//         {
//             PlayerAttack.instance.HealAmount = Itemdata[ind].healAmount;
//         }
//     }

//     void check()
//     {
//         if(ind != -1)
//         {
//             SetItemType();
//             SetAttackAmount(itemType);
//         }
//     }

//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         check();
//     }
// }
