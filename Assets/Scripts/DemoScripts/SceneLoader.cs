// Date updated: 2023-02-13
using System.Collections;
// Date updated comment added to file for the first time
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SceneLoader : MonoBehaviour
{
    [SerializeField]RectTransform fader;

    
    public void LoadLevel(int sceneIndex)
    {
        fader.gameObject.SetActive(true);
        LeanTween.scale(fader,new Vector3(1,0,1), 0f);
        LeanTween.scale(fader,new Vector3(1,1,1),1f).setEase(LeanTweenType.easeInOutQuad).setOnComplete(()=>
        {
            StartCoroutine(ChangeScene(sceneIndex));

        });
      
    }
    
 
    IEnumerator ChangeScene(int sceneIndex)
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadSceneAsync(sceneIndex);
    } 
   
}
