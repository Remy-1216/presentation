using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class asuka : MonoBehaviour
{
    string name; //���O
    int maxHp = 320; //�ő�HP
    public int hp;    //Hp�Ǘ��p
    int GetGold; //�擾�ł����

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
