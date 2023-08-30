using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    public nagato player1;
    public asuka player2;
    public yamato player3;

    int rund;
    int damage;
    int playerTurn = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
 
        if (Input.GetMouseButtonDown(0))
        {
            damage_knife();
        }
    }

    public void damage_knife() //成功か失敗かの判定の後　味方のAtに代入
    {
        rund = Random.Range(1, 100); //1~100の間でランダムの数値を出す

        if (rund <= 60)
        {
            for (int i = 1; i <= playerTurn; i++)
            {
                if (i == 1)
                {
                    damage = Random.Range(20, 30);
                    player1.offensivePower(damage);
                }
                else if (i == 2)
                {
                    damage = Random.Range(20, 30);
                    player2.offensivePower(damage);
                }
                else
                {
                    damage = Random.Range(20, 30);
                    player3.offensivePower(damage);
                }
            }
        }
        else
        {
            damage = 0;
                for (int i = 1; i <= playerTurn; i++)
            {
                if (i == 1)
                {
                    player1.offensivePower(damage);
                }
                else if (i == 2)
                {
                    player2.offensivePower(damage);
                }
                else
                {
                    player3.offensivePower(damage);
                }
            }
        }


    }
}
