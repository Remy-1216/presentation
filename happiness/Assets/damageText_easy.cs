using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageText_easy : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI damageText_at; //テキストの設定

    public nagato player1; //ナガトの情報
    public asuka player2;  //アスカの情報
    public yamato player3; //ヤマトの情報


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // テキストの内容を表示する
        damageText_at.text = "ナガトの攻撃" + player1.at +"ダメージ" + "\nアスカの攻撃"  + player2.at + "ダメージ"+ "\nヤマトの攻撃" + player3.at + "ダメージ";
    }
}
