using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class nagato : MonoBehaviour
{
    
    string  name; //–¼‘O
    int maxHp = 300; //Å‘åHP
    public int getGold; //æ“¾‚Å‚«‚é‚¨‹à
    public int hp; //hpŠÇ——p

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
