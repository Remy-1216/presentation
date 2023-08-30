using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class punch : MonoBehaviour
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
    void Update()
    {
         if (Input.GetMouseButtonDown(0))
         {
           rund = Random.Range(1, 100); //1~100‚ÌŠÔ‚Åƒ‰ƒ“ƒ_ƒ€‚Ì”’l‚ğo‚·
              if (rund <= 80)
                {
                for (int i = 1; i <= playerTurn; i++)
                {
                    if (i == 1)
                    {
                        damage = Random.Range(10, 20);
                        player1.offensivePower(damage);
                    }
                    else if (i == 2)
                    {
                        damage = Random.Range(10, 20);
                        player2.offensivePower(damage);
                    }
                    else
                    {
                        damage = Random.Range(10, 20);
                        player3.offensivePower(damage);
                    }
                }
            }
         }        
        
        
    }
}
