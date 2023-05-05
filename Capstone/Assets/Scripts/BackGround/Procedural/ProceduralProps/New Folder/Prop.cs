using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Prop : ScriptableObject
{
    [Header("Prop data:")]
    public Sprite PropSprite;
    /// <summary>
    /// Affects the collider size of the prop
    /// </summary>
    public Vector2Int PropSize = Vector2Int.one;

    [Space, Header("Placement type:")]
    public bool Inner = true;
    [Min(0)]
    public int PlacementPerRoomsMin = 0;
    [Min(1)]
    public int PlacementPerRoomsMax = 1;
    [Min(0)]
    public int MaxAmount;

    [Space, Header("Group placement:")]
    public bool PlaceAsGroup = false;
    [Min(1)]
    public int GroupMinCount = 1;
    [Min(1)]
    public int GroupMaxCount = 1;


    [Space, Header("Enemy:")]
    public bool Enemy = false;
    public string enemyName;
    public int hp;
    public int minDamage;
    public int maxDamage;

    [Space, Header("Potion:")]
    public bool healPotion = false;
    public bool skillPotion = false;
    public int healAmount;

    [Space, Header("Weapon:")]
    public bool weapon = false;
    public string weaponName;
    public int weaponDamage;


}