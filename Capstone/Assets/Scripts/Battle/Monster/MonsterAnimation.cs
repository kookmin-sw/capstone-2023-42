using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MonsterAnimation : MonoBehaviour
{
    public static MonsterAnimation instance;
    public Color red;
    public Color origin;

    private void Awake() 
    {
        instance = this;
    }
    public IEnumerator ChangeColor()
    {
        GetComponent<Image>().color = red;
        yield return new WaitForSeconds(0.5f);
        GetComponent<Image>().color = origin;
    }

    public IEnumerator ChangeSize()
    {
        GetComponent<RectTransform>().sizeDelta = new Vector2(800,900);
        yield return new WaitForSeconds(0.5f);
        GetComponent<RectTransform>().sizeDelta = new Vector2(400,450);        
    }
}
