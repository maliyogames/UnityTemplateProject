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
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            sfxSource.clip = sfxClip;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySFX()
    {
        sfxSource.PlayOneShot(sfxClip);
    }
}
