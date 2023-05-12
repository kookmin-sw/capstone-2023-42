using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    Button attButton;
    public static ExitButton instance;
    public int AButton = 0;

    void Awake()
    {
        instance = this;
    }

    public void OnClickButton()
    {
        InventoryOnOff.instance.Ivt = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        attButton = GetComponent<Button>();
        attButton.onClick.AddListener(OnClickButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
