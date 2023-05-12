using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemInfo : MonoBehaviour
{
    [SerializeField]
    public Prop propInfo;
    public Prop Prop{set{propInfo = value;}}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(propInfo.Enemy == true)
        {

        }
        else if(propInfo.healPotion == true)
        {

        }
        else if(propInfo.skillPotion == true)
        {

        }
        else if(propInfo.weapon == true)
        {

        }
        else if(propInfo.exit == true)
        {
            SceneManager.LoadScene("GameClear");
        }
        
    }
}
