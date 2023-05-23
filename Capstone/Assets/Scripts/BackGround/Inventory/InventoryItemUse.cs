using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemUse : MonoBehaviour
{
    public GameObject ItemObj;
    public Slot ItemSlot;
    public Image ItemUse;
    public GameObject PlayerObj;
    public Player PlayerSC;
    
    void Start()
    {
        Invoke("setup", 3.0f);
    }

    void setup(){
        PlayerObj = GameObject.FindGameObjectsWithTag("Player")[0];
        PlayerSC = PlayerObj.GetComponent<Player>();
    }
    public void use(){
        if(ItemSlot.item.healPotion == true){
            PlayerSC.HP += ItemSlot.item.healAmount;
        }

        else if(ItemSlot.item.skillPotion == true){
            PlayerSC.SP += ItemSlot.item.healAmount;
        }

        else if(ItemSlot.item.weapon == true){
            PlayerSC.Attack = ItemSlot.item.weaponDamage;
        }
        ItemUse.sprite = ItemSlot.itemImage;
        ItemUse.color = new Color(1,1,1,1);
        Debug.Log("ASDSAd");
        trash();
    }
    public void trash(){
        if(ItemSlot != null){
            ItemSlot.button.SetActive(false);
            ItemSlot.ClearSlot();
            ItemSlot = null;
        }
    }
    public void quit(){
        if(ItemSlot != null){
            ItemSlot.button.SetActive(false);
            ItemSlot = null;
        }
    }
}
