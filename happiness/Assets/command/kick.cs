using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kick : MonoBehaviour
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
            rund = Random.Range(1, 100); //1~100‚ÌŠÔ‚Åƒ‰ƒ“ƒ_ƒ€‚Ì”’l‚ğo‚·

            if (rund <= 70)
            {
                
                for (int i = 1; i <= playerTurn; i++)
                {
                    if (i == 1)
                    {
                        damage = Random.Range(15, 26);
                        player1.offensivePower(damage);
                    }
                    else if (i == 2)
                    {
                        damage = Random.Range(15, 26);
                        player2.offensivePower(damage);
                    }
                    else if(i == 3)
                    {
                        damage = Random.Range(15, 26);
                        player3.offensivePower(damage);
                    }
                }
            }
        }
    }
}
