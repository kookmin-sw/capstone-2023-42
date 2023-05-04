using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemMenu", menuName = "Scriptable Object/Potion Data", order = int.MaxValue)]
public class ItemData : ScriptableObject
{
    [SerializeField]
    private string potionName;
    public string getPotionName{get{return potionName;}}
    [SerializeField]
    private int potionLevel;
    public int getPotionLevle {get{return potionLevel;}}
    [SerializeField]
    private int heal;
    public int getHeal{get{return heal;}}
    [SerializeField]
    private int skill;
    public int getSkill{get{return skill;}}
}
