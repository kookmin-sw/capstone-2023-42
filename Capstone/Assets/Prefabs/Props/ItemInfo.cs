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
                // GameObject invenWin = GameObject.FindGameObjectWithTag("Inven");
                GameObject invenObj = GameObject.Find("Inventory");
                if(invenObj== null)
                    Debug.Log("invenObj null");
                // invenWin.SetActive(true);
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

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class ItemInfo : MonoBehaviour
// {
//     [SerializeField]
//     public Prop propInfo;
//     public Prop Prop { set { propInfo = value; } }

//     public GameObject obj;


//     private void Awake()
//     {
//         obj = GameObject.Find("ExitComfirm");
        
//     }

//     private void OnCollisionEnter2D(Collision2D collision)
//     {

//         if (propInfo.exit == true)
//         {
//             obj.SetActive(true);
//         }
//         else
//         {
//             GameObject invenObj = GameObject.Find("Inventory");
//             Inventory test = invenObj.GetComponent<Inventory>();
//             test.AcquireItem(propInfo);
//             Destroy(gameObject);
//         }
//     }
// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;
// using UnityEngine.UI;

// public class ItemInfo : MonoBehaviour
// {
//     [SerializeField]
//     public Prop propInfo;
//     public Prop Prop { set { propInfo = value; } }

//     public Canvas canvas;

//     private void Awake()
//     {
//         canvas = GameObject.Find("ExitCanvas").GetComponent<Canvas>();
        
//         if (canvas == null)
//         {
//             Debug.LogError("Canvas object not found or Canvas component missing.");
//         }
//         else
//         {
//             canvas.gameObject.SetActive(false);
//         }
//     }

//     private void OnCollisionEnter2D(Collision2D collision)
//     {
//         if (propInfo.exit == true)
//         {
//             canvas.gameObject.SetActive(true);
//         }
//         else
//         {
//             GameObject invenObj = GameObject.Find("Inventory");
//             Inventory test = invenObj.GetComponent<Inventory>();
//             test.AcquireItem(propInfo);
//             Destroy(gameObject);
//         }
//     }
// }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class ItemInfo : MonoBehaviour
// {
//     [SerializeField]
//     public Prop propInfo;
//     public Prop Prop{set{propInfo = value;}}

//     private void OnCollisionEnter2D(Collision2D collision)
//     {
//         if(propInfo.exit == true)
//         {
//             Transform exitObj = transform.Find("ExitCanvas");
            
//             if (exitObj != null)
//             {
//                 exitObj.gameObject.SetActive(true);
//             }
//             else
//             {
//                 Debug.LogError("ExitCanvas object not found.");
//             }
//         }
//         else
//         {
//             GameObject invenObj = GameObject.Find("Inventory");
//             Inventory test = invenObj.GetComponent<Inventory>();
//             test.AcquireItem(propInfo);
//             Destroy(gameObject);
//         }
//     }
// }