using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyText_Shell : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI enemyDamageText_at; //�e�L�X�g�̐ݒ�
    public shell enemy;
    public nagato player1; //�i�K�g�̏��
    public asuka player2;  //�A�X�J�̏��
    public yamato player3; //���}�g�̏��
    public normalBattleMain system;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!system.isTurn)
        {
            if (system.rund == 1)
            {
                enemyDamageText_at.text = "�G��HP�͎c��" + enemy.hp + "\n�G�̍U��!" + enemy.at + "�_���[�W\n�i�K�g�ɓ�������\n�c��" + player1.hp;
            }

            else if (system.rund == 2)
            {
                enemyDamageText_at.text = "�G��HP�͎c��" + enemy.hp + "\n�G�̍U��!" + enemy.at + "�_���[�W\n�A�X�J�ɓ�������\n�c��" + player2.hp;
            }
            else
            {
                enemyDamageText_at.text = "�G��HP�͎c��" + enemy.hp + "\n�G�̍U��!" + enemy.at + "�_���[�W\n���}�g�ɓ�������\n�c��" + player3.hp;
            }
        }

    }
}
