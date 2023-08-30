using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン切り替えに必要なため

//クリックしたら、シーンを切り替える

public class TitleScene : MonoBehaviour
{
    public string sceneName;

    void OnMouseDown()
    {
        //シーンを切り替える

        SceneManager.LoadScene(sceneName);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
