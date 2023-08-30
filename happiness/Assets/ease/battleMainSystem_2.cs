using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleMainSystem_2 : MonoBehaviour
{
    public nagato player1; //ナガトのステータス
    public asuka player2;  //アスカのステータス
    public yamato player3; //ヤマトのステータス
    public dog enemy;    //敵のステータス

    public int rund;              //確率
    public bool isTurn_2;    //敵のターンか味方のターンかの判定
    public int playerIsTurn = 3;



    // Start is called before the first frame update
    void Start()
    {
        isTurn_2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTurn_2)
        {
            isTurn_2 = true;
            //enemy攻撃対象を決める
            dogAttack_subject();

        }
    }

    public void attackButton_2()
    {
        for (int i = 1; i <= playerIsTurn; i++)
        {
            if (i == 1)
            {
                enemy.onDogDamage(player1.at);
            }
            else if (i == 2)
            {
                enemy.onDogDamage(player2.at);
            }
            else if (i == 3)
            {
                enemy.onDogDamage(player3.at);
            }
            isTurn_2 = false;
        }
    }

    private void dogAttack_subject() //1体目のenemyの攻撃対象を決める
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
