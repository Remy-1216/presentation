using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

public class dog : MonoBehaviour
{
    int enemyMaxHp = 450;
    public int hp;
    int rund;
    public int at = 25;
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

    public void onDogDamage(int _damage)
    {
        hp -= _damage;
        
        Debug.Log(hp);

        if (hp <= 0)
        {
            hp = 0;

            player1.getGold = player1.getGold + 50000;

            Destroy(gameObject);

            nextStage(); //���񂾂玟�̃X�e�[�W

        }
    }
    void nextStage() //�G��|�����玟�̃X�e�[�W��
    {
        SceneManager.LoadScene(sceneName);
    }
}
