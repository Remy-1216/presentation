using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class nagato : MonoBehaviour
{
    
    string  name; //���O
    int maxHp = 300; //�ő�HP
    public int getGold; //�擾�ł��邨��
    public int hp; //hp�Ǘ��p

    public int at; //�U����

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
        // �����ɋ�̓I�Ȏ��S����
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
