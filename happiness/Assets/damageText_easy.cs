using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageText_easy : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI damageText_at; //�e�L�X�g�̐ݒ�

    public nagato player1; //�i�K�g�̏��
    public asuka player2;  //�A�X�J�̏��
    public yamato player3; //���}�g�̏��


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �e�L�X�g�̓��e��\������
        damageText_at.text = "�i�K�g�̍U��" + player1.at +"�_���[�W" + "\n�A�X�J�̍U��"  + player2.at + "�_���[�W"+ "\n���}�g�̍U��" + player3.at + "�_���[�W";
    }
}
