using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class asuka : MonoBehaviour
{
    string name; //名前
    int maxHp = 320; //最大HP
    public int hp;    //Hp管理用
    int GetGold; //取得できる金

    public int at; //攻撃力

    void Start()
    {
        hp = maxHp;
    }

    public void offensivePower(int _power)
    {
        at = _power;
    }

    public void onDamage(int _damage)
    {
        hp -= _damage;
        Debug.Log(hp);
    }

    void Death()
    {
        // ここに具体的な死亡処理
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
