using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

public class next : MonoBehaviour
{
    public string sceneName;

    // Update is called once per frame
    void Update()
    {
        OnMouseDown();
    }


    void OnMouseDown()
    {
        //�V�[����؂�ւ���

        SceneManager.LoadScene(sceneName);

    }
}
