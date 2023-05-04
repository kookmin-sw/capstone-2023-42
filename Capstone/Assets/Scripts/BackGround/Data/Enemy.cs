using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{  
    [SerializeField]
    private EnemyData enemy;
    public EnemyData setEnemy{set{enemy = value;}}

    public void enemyInfo()
    {
        Debug.Log("몬스터 이름 :: " + enemy.getName);
        Debug.Log("몬스터 체력 :: " + enemy.getHealth);
        Debug.Log("몬스터 최소 공격력 :: " + enemy.getMinDamage);
        Debug.Log("몬스터 최대 공격력 :: " + enemy.getMaxDamage);
        Debug.Log("몬스터 약점 무기 :: " + enemy.getWeakWeapon);
    }
}
