using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

//�N���b�N������A�V�[����؂�ւ���

public class TitleScene : MonoBehaviour
{
    public string sceneName;

    void OnMouseDown()
    {
        //�V�[����؂�ւ���

        SceneManager.LoadScene(sceneName);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
