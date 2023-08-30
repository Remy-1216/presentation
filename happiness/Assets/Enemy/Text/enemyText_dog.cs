using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyText_dog : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI dogDamageText_at; //テキストの設定
    public dog enemy;
    public nagato player1; //ナガトの情報
    public asuka player2;  //アスカの情報
    public yamato player3; //ヤマトの情報
    public battleMainSystem_2 system;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!system.isTurn_2)
        {
            if (system.rund == 1)
            {
                dogDamageText_at.text = "敵のHPは残り" + enemy.hp + "\n敵の攻撃!" + enemy.at + "ダメージ\nナガトに当たった\n残り" + player1.hp;
            }

            else if (system.rund == 2)
            {
                dogDamageText_at.text = "敵のHPは残り" + enemy.hp + "\n敵の攻撃!" + enemy.at + "ダメージ\nアスカに当たった\n残り" + player2.hp;
            }
            else
            {
                dogDamageText_at.text = "敵のHPは残り" + enemy.hp + "\n敵の攻撃!" + enemy.at + "ダメージ\nヤマトに当たった\n残り" + player3.hp;
            }
        }
    }
}
