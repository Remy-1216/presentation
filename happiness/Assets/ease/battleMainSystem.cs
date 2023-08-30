using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class battleMainSystem : MonoBehaviour
{
    public nagato player1; //ナガトのステータス
    public asuka player2;  //アスカのステータス
    public yamato player3; //ヤマトのステータス
    public snake enemy;    //敵のステータス

    public int rund;              //確率
    public bool isTurn;    //敵のターンか味方のターンかの判定
    public int playerIsTurn = 3;



    // Start is called before the first frame update
    void Start()
    {
        isTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTurn)
        {
            isTurn = true;
            //攻撃対象を決める
            enemyAttack_subject();
        }
    }

    public void attackButton()
    {
            for (int i = 1; i <= playerIsTurn; i++)
            {
                if (i == 1)
                {
                    enemy.onDamage(player1.at);
                }
                else if (i == 2)
                {
                    enemy.onDamage(player2.at);
                }
                else if (i == 3)
                {
                    enemy.onDamage(player3.at);
                }
                isTurn = false;

            }
        
        
    }

    private void enemyAttack_subject()
    {
        //攻撃対象をランダムで決める

        rund = Random.Range(1, 3); //1~3で攻撃対象を決める
        if (rund == 1)
        {
            player1.onDamage(enemy.at);
        }
        else if (rund == 2)
        {
            player2.onDamage(enemy.at);
        }
        else
        {
            player3.onDamage(enemy.at);
        }

    }
}


