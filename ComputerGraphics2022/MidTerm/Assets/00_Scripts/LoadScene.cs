using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public Object SceneToLoad;

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPSController")
        {
            SceneManager.LoadScene(SceneToLoad.name);
        }   
    }
}
