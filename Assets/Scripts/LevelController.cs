using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelController : MonoBehaviour
{
    [SerializeField] GameStateManager GameStateManager;
    Button[] levelbuttons;
    // Start is called before the first frame update
    void Start()
    {
        int reachedLevel = PlayerPrefs.GetInt("ReachedLevel", 1);
        if(PlayerPrefs.GetInt("Level")>=2)
        {
            reachedLevel = PlayerPrefs.GetInt("Level");
        }
       levelbuttons = new Button[transform.childCount];
        for(int i=0;i<levelbuttons.Length;i++) 
        {
            levelbuttons[i] = transform.GetChild(i).GetComponent<Button>();
            levelbuttons[i].GetComponentInChildren<Text>().text = (i+1).ToString();
            if(i+1>reachedLevel)
            {
                levelbuttons[i].interactable = false;
            }
        }
    }

    public void LoadScene(int level)
    {
        PlayerPrefs.SetInt("Level", level);
        Application.LoadLevel("Loading");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
