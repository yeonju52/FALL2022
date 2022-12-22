using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class A_LoadScene : MonoBehaviour
{
    //Scene CurrentScene;

    //void Start()
    //{
    //    CurrentScene = gameObject.scene;
    //    print(CurrentScene.name);    
    //}

    //첫번째 버전
    //private void OnMouseDown()
    //{
    //    //SceneManager.LoadScene("A_LoadScene_Outdoors");
    //    SceneManager.LoadScene(SceneToLoad.name);
    //}

    //두번째 버전
    public Object SceneToLoad;
    private void OnMouseDown()
    {
        SceneManager.LoadScene(SceneToLoad.name);
    }
}
