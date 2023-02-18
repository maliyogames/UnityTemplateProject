using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;

    public AudioSource sfxSource;
    public AudioClip sfxClip;


     private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
        sfxSource.clip=sfxClip;
    }
     public void PlaySFX()
    {
        sfxSource.PlayOneShot(sfxClip);
    }


    
}
