using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunButton : MonoBehaviour
{
    Button attButton;
    public static RunButton instance;
    public int AButton = 0;

    void Awake()
    {
        instance = this;
    }

    public void OnClickButton()
    {
        SceneManager.LoadScene("BackGround_Test");
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
