using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileMenu = "WeaponData", menuName = "Scriptable Object/Weapon Data", order = int.MaxValue)]
public class WeaponData : ScriptableObject
{
    [SerializeField]
    private string weaponName;
    public string weaponName{get{return weaponName;}}
    [SerializeField]
    private int weaponLevel;
    public int weaponLevel{get{return weaponLevel;}}
    [SerializeField]
    private int ;
    public int {get{return ;}}
    
}
