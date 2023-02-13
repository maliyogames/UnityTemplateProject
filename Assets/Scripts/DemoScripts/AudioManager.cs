using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] AudioMixer mixer;
    [SerializeField] AudioSource sfxSource;
    [SerializeField] List<AudioClip> sfxClip = new List<AudioClip>();
    [SerializeField] AudioClip sfxAudio;
    public const string MUSIC_KEY="bgVolume"; 
    public const string SFX_KEY="sfxVolume";
    void Awake() 
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            
        }
        LoadVolume();
    }
    public void PlayRandomSFX()
    {
        AudioClip clip = sfxClip[Random.Range(0, sfxClip.Count)];
        sfxSource.PlayOneShot(clip);
    }
    void LoadVolume()//volume is saved in the volumesettings
    {
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY,1f);
        
        float sfxVolume = PlayerPrefs.GetFloat(SFX_KEY,1f);
        mixer.SetFloat(VolumeSettings.MIXER_MUSIC, Mathf.Log10(musicVolume) *20);
        mixer.SetFloat(VolumeSettings.MIXER_SFX, Mathf.Log10(musicVolume) *20);
        
    }
   
}
