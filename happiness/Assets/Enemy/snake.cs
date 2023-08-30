using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン切り替えに必要なため

public class snake : MonoBehaviour
{  
    int enemyMaxHp = 150;
    public int hp;
    int rund;
    public int at = 10;
    public static int value;
    public nagato player1;
    public string sceneName;

    void Start()
    {
        value = at;

        hp = enemyMaxHp;
    }

    void Update() 
    {
      
    }

    public void onDamage(int _damage)
    {
        hp -= _damage;
        Debug.Log(hp);

        if (hp <= 0)
        {
            hp = 0;

            player1.getGold = player1.getGold + 10000;

            Destroy(gameObject);

            nextStage(); //死んだら次のステージ
        }
    }

    void nextStage() //敵を倒したら次のステージへ
    {
        SceneManager.LoadScene(sceneName);
    }
}
