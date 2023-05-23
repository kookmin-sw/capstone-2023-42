using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject obj;
    public Slot script;
    public bool SA = false;

    // public GameObject PlayerObj;
    // public Player PlayerSC;

    // void Update() {
    //     Slot script = obj.GetComponent<Slot>();
    // }
    public void btt(){
        if(script.item != null)
        {
            if(SA == false){
                this.gameObject.SetActive(true);
                SA = true;
            }
            else{
                this.gameObject.SetActive(false);
                SA = false;
            }
        }
        else{

        }
    
    }
}
