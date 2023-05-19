using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemInfo : MonoBehaviour
{
    [SerializeField]
    public Prop propInfo;
    public Prop Prop{set{propInfo = value;}}

    private GameObject exitWin;

    private void Awake()
    {
        // instance = this;
        exitWin = GameObject.Find("ExitCanvas");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) {
            if(propInfo.exit == true)
            {   
                GameObject exitObj = exitWin.transform.Find("ExitComfirm").gameObject;
                exitObj.SetActive(true);
                // SceneManager.LoadSceneAsync("GameClear");
            }
            
            else{
                GameObject invenWin = GameObject.FindGameObjectWithTag("Inven");
                GameObject invenObj = GameObject.Find("Inventory");
                if(invenWin != null)
                    Debug.Log("invenWin not null");
                invenWin.SetActive(true);
                Inventory test = invenObj.GetComponent<Inventory>();
                test.AcquireItem(propInfo);
                Destroy(gameObject);
                // invenWin.SetActive(false);
            }
        }
    }
    public void gameClear(){
        SceneManager.LoadScene("GameClear");
    }
}
