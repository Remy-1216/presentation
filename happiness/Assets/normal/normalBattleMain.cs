using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalBattleMain : MonoBehaviour
{
    public nagato player1; //�i�K�g�̃X�e�[�^�X
    public asuka player2;  //�A�X�J�̃X�e�[�^�X
    public yamato player3; //���}�g�̃X�e�[�^�X
    public shell enemy;    //�G�̃X�e�[�^�X

    public int rund;              //�m��
    public bool isTurn;    //�G�̃^�[���������̃^�[�����̔���
    public int playerIsTurn = 3;



    // Start is called before the first frame update
    void Start()
    {
        isTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTurn)
        {
            isTurn = true;
            //�U���Ώۂ����߂�
            enemyAttack_subject();
        }
    }

    public void attackButton()
    {
        playerAttack();//�����̍U���^�[��
    }
    private void enemyAttack_subject() //�U���Ώۂ����߂�
    {
        //�U���Ώۂ������_���Ō��߂�

        rund = Random.Range(1, 3); //1~3�ōU���Ώۂ����߂�
        if (rund == 1)
        {
            player1.onDamage(enemy.at);
        }
        else if (rund == 2)
        {
            player2.onDamage(enemy.at);
        }
        else
        {
            player3.onDamage(enemy.at);
        }

    }

    private void playerAttack()//�����̍U���^�[��
    {
        for (int i = 1; i <= playerIsTurn; i++)
        {
            if (i == 1)
            {
                enemy.onDamage_Shell(player1.at);
            }
            else if (i == 2)
            {
                enemy.onDamage_Shell(player2.at);
            }
            else if (i == 3)
            {
                enemy.onDamage_Shell(player3.at);
            }
            isTurn = false;
        }

    } 
}
