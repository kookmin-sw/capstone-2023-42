using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dungeon.Data
{
    [CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Object/Weapon Data", order = int.MaxValue)]
    public class WeaponData : ScriptableObject
    {
        // [SerializeField]
        // private int weaponID;
        // public int getWeaponID{get{return weaponID;}}
        [SerializeField]
        private string weaponName;
        public string getWeaponName{get{return weaponName;}}
        [SerializeField]
        private int weaponLevel;
        public int getWeaponLevel{get{return weaponLevel;}}
        [SerializeField]
        private int weaponDamage;
        public int getWeaponDamage{get{return weaponDamage;}}
        [SerializeField]
        private int weaponSpeed;
        public int getWeaponSpeed{get{return weaponSpeed;}}
        
        
    }
}

