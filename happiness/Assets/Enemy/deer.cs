using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

public class deer : MonoBehaviour
{
    int enemyMaxHp = 500;
    public int hp;
    public int at = 30;
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
            Destroy(this.gameObject);
            player1.getGold = player1.getGold + 80000;

            nextStage(); //���񂾂玟�̃X�e�[�W
        }
    }

    void nextStage() //�G��|�����玟�̃X�e�[�W��
    {
        SceneManager.LoadScene(sceneName);
    }
    
}
