using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yamato : MonoBehaviour
{ 
    string Name; //名前
    int maxHp = 325; //最大HP
    int GetGold; //取得できる金
    public int hp;     //HP管理用

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
