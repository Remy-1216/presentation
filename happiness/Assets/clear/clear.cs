using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clear : MonoBehaviour
{
    [SerializeField]
    private TMPro.TextMeshProUGUI reward; //�e�L�X�g�̐ݒ�
    public nagato player;
    public int Debt = 1000000;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Debt = Debt - player.getGold;
        reward.text = "�N���A�I�I�I\n��V��" + player.getGold + "\n�c��" + Debt;
    }
}
