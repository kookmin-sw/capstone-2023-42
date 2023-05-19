using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemButton : MonoBehaviour
{
    Button attButton;
    public static ItemButton instance;
    [SerializeField] public int ButtonNum = 0;

    void Awake()
    {
        instance = this;
    }

    public void OnClickButton()
    {
        Item.instance.selectItem = ButtonNum;
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
