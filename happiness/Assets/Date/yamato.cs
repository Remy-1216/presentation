using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yamato : MonoBehaviour
{ 
    string Name; //–¼‘O
    int maxHp = 325; //Å‘åHP
    int GetGold; //æ“¾‚Å‚«‚é‹à
    public int hp;     //HPŠÇ——p

    public int at; //UŒ‚—Í

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
        // ‚±‚±‚É‹ï‘Ì“I‚È€–Sˆ—
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
