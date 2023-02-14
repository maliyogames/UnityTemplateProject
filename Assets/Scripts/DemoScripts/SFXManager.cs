using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;



    private AudioSource sfxSource;
    [SerializeField] private List<AudioClip> sfxClips = new List<AudioClip>();

    private void Awake()
    {
        sfxSource = GetComponent<AudioSource>();
        
    }

    public void PlaySFX(int index)
    {
        if (sfxClips == null || sfxClips.Count == 0 || index < 0 || index >= sfxClips.Count)
        {
            Debug.LogError("Invalid index or no sound clips specified.");
            return;
        }

        AudioClip clip = sfxClips[index];
        sfxSource.PlayOneShot(clip);
    }
}
