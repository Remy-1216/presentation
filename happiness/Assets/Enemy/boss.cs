using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

public class boss : MonoBehaviour
{

    int enemyMaxHp = 900; //�ő�Hp
    public int hp; //HP�Ǘ�
    public int at = 45; //�U����
    public static int value;
    public nagato player1;
    public string sceneName;

    void Start()
    {
        value = at;

        hp = enemyMaxHp;
    }

    void Update()
    {

    }

    public void onDamage(int _damage)
    {
        hp -= _damage;
        Debug.Log(hp);

        if (hp <= 0)
        {
            hp = 0;

            player1.getGold = player1.getGold + 200000;

            Destroy(gameObject);

            nextStage(); //���񂾂玟�̃X�e�[�W
        }
    }

    void nextStage() //�G��|�����玟�̃X�e�[�W��
    {
        SceneManager.LoadScene(sceneName);
    }
}