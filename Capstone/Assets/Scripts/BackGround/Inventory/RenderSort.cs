using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderSort : MonoBehaviour
{
    public string targetTag = "ItemButton";
    public int sortingOrder = -1;

    private void Start()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag(targetTag);
        
        foreach (GameObject obj in objects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sortingOrder = sortingOrder;
            }
        }
    }
}
