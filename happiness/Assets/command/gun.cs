using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public nagato player1;
    public asuka player2;
    public yamato player3;


    int rund;
    int damage;
    int playerTurn = 3;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rund = Random.Range(1, 100); //1~100�̊ԂŃ����_���̐��l���o��

            if (rund <= 50)
            {
                
                for (int i = 1; i <= playerTurn; i++)
                {
                    if (i == 1)
                    {
                        damage = Random.Range(35, 45);
                        player1.offensivePower(damage);
                    }
                    else if (i == 2)
                    {
                        damage = Random.Range(35, 45);
                        player2.offensivePower(damage);
                    }
                    else if(i == 3)
                    {
                        damage = Random.Range(35, 45);
                        player3.offensivePower(damage);
                    }
                }
            }
        }
    }
        
}
