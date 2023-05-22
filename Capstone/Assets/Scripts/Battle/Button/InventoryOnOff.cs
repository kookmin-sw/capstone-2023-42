using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnOff : MonoBehaviour
{
    public static InventoryOnOff instance;
    [SerializeField] public bool Ivt;
    GameObject IvtImage;

    void Awake()
    {
        instance = this;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Ivt = false;
        IvtImage = GameObject.Find("InventoryBackGround");
    }

    // Update is called once per frame
    void Update()
    {
        if (Ivt)
        {
            IvtImage.SetActive(true);
        }
        else
        {
            IvtImage.SetActive(false);
        }
        
    }
}
