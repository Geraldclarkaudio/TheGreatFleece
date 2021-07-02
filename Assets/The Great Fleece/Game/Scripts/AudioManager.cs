using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Singleton Audio Manager

    private static AudioManager _instance;

    //property
    public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("AudioManager is null");
            }

            return _instance;
        }
    }

    public AudioSource voiceOver;
    public AudioSource music;


    private void Awake()
    {
        _instance = this;   
    }

    public void PlayVOiceOver(AudioClip clipToPlay)
    {
        voiceOver.clip = clipToPlay;
        voiceOver.Play();
    }

    public void PlayMusic()
    {
        music.Play();
    }

}
