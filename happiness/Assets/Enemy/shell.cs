using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

public class shell : MonoBehaviour
{
    int enemyMaxHp = 300;
    public int hp;
    int rund;
    public int at = 20;
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

    public void onDamage_Shell(int _damage)
    {
        hp -= _damage;
        Debug.Log(hp);

        if (hp <= 0)
        {
            hp = 0;

            player1.getGold = player1.getGold + 30000;

            Destroy(gameObject);

            nextStage(); //���񂾂玟�̃X�e�[�W
        }
    }
    void nextStage() //�G��|�����玟�̃X�e�[�W��
    {
        SceneManager.LoadScene(sceneName);
    }
}
