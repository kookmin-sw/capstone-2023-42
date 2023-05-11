using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     // 충돌한 상대방이 "Enemy" 태그를 가진 경우
    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {
    //         // Battle 씬으로 전환
    //         SceneManager.LoadScene("Battle");
    //     }
    // }

    // private void OnCollisionEnter2D(Collision2D collision)
    // {
    //     // 충돌한 상대방이 "Enemy" 태그를 가진 경우
    //     if (collision.gameObject.CompareTag("Enemy"))
    //     {
    //         // 상대방 객체의 Enemy 컴포넌트를 가져오기
    //         Enemy enemy = collision.gameObject.GetComponent<Enemy>();
    //         if (enemy != null)
    //         {
    //             // Battle 씬으로 전환
    //             SceneManager.LoadScene("Battle");

    //             // 전달할 정보를 저장하는 클래스를 작성
    //             BattleInfo info = new BattleInfo();
    //             info.enemyName = enemy.enemyName;
    //             info.enemyHp = enemy.hp;
    //             info.enemyMinDmg = enemy.minDamage;
    //             info.enemyMaxDmg = enemy.minDamage;

    //             // 전달할 정보를 가진 객체를 Battle 씬으로 전달
    //             DontDestroyOnLoad(info);
    //         }
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            if (enemy != null)
            {
                SceneManager.LoadScene("Battle");
                BattleInfo info = new BattleInfo();
                info.enemyName = enemy.enemyName;
                info.enemyHp = enemy.hp;
                info.enemyMinDmg = enemy.minDamage;
                info.enemyMaxDmg = enemy.maxDamage;
                DontDestroyOnLoad(info);
            }
        }
    }
}
