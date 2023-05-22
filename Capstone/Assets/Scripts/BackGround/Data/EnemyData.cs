using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Dungeon.Data;

[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable Object/Enemy Data", order = int.MaxValue)]
public class EnemyData : ScriptableObject
{
    [SerializeField]
    private string enemyName;
    public string getName{get{return enemyName;}}
    [SerializeField]
    private float health;
    public float getHealth{get{return health;}}
    [SerializeField]
    private int minDamage;
    public int getMinDamage{get{return minDamage;}}
    [SerializeField]
    private int maxDamage;
    public int getMaxDamage{get{return maxDamage;}}
    [SerializeField]
    private WeaponData weakWeapon;
    public WeaponData getWeakWeapon{get{return weakWeapon;}}
}
