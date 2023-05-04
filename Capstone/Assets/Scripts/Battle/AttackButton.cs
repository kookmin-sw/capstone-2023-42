using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackButton : MonoBehaviour
{
    Button attButton;
    public static AttackButton instance;
    public int AButton = 0;
    
    void Awake()
    {
        instance = this;
    }

    public void OnClickButton()
    {
        AButton = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        attButton = GetComponent<Attack>();
        attButton.onClick.AddListener(OnClickButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
