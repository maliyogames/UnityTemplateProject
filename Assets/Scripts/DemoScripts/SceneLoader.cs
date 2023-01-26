using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class SceneLoader : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 10f; //This is the amount of time a delay should occur.By default it is set to 10
    [SerializeField]
    private string sceneNameToLoad; // This specifies which scene by the name of the scene.
    private float timeElapsed;//This calcuates the time
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if(timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }

    }
}
