using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class yamato : MonoBehaviour
{ 
    string Name; //���O
    int maxHp = 325; //�ő�HP
    int GetGold; //�擾�ł����
    public int hp;     //HP�Ǘ��p

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
