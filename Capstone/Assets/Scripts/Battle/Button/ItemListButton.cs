using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListButton : MonoBehaviour
{
    Button attButton;
    public static ItemListButton instance;
    public int AButton = 0;

    void Awake()
    {
        instance = this;
    }

    public void OnClickButton()
    {

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
