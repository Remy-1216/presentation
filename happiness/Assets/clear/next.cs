using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン切り替えに必要なため

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
        //シーンを切り替える

        SceneManager.LoadScene(sceneName);

    }
}
