using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�V�[���؂�ւ��ɕK�v�Ȃ���

public class easymode_button : MonoBehaviour
{

    public string sceneName;



    void OnMouseDown()
    {
        //�V�[����؂�ւ���

        SceneManager.LoadScene(sceneName);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
