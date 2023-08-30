using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class battleMainSystem_2 : MonoBehaviour
{
    public nagato player1; //�i�K�g�̃X�e�[�^�X
    public asuka player2;  //�A�X�J�̃X�e�[�^�X
    public yamato player3; //���}�g�̃X�e�[�^�X
    public dog enemy;    //�G�̃X�e�[�^�X

    public int rund;              //�m��
    public bool isTurn_2;    //�G�̃^�[���������̃^�[�����̔���
    public int playerIsTurn = 3;



    // Start is called before the first frame update
    void Start()
    {
        isTurn_2 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isTurn_2)
        {
            isTurn_2 = true;
            //enemy�U���Ώۂ����߂�
            dogAttack_subject();

        }
    }

    public void attackButton_2()
    {
        for (int i = 1; i <= playerIsTurn; i++)
        {
            if (i == 1)
            {
                enemy.onDogDamage(player1.at);
            }
            else if (i == 2)
            {
                enemy.onDogDamage(player2.at);
            }
            else if (i == 3)
            {
                enemy.onDogDamage(player3.at);
            }
            isTurn_2 = false;
        }
    }

    private void dogAttack_subject() //1�̖ڂ�enemy�̍U���Ώۂ����߂�
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
}
