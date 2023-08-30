using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //シーン切り替えに必要なため

public class easymode_button : MonoBehaviour
{

    public string sceneName;



    void OnMouseDown()
    {
        //シーンを切り替える

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
