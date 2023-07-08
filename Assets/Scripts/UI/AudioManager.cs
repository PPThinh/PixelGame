using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    // quan ly cac sound trong menu
    public static AudioManager instance;

    public Sound[] musicSounds, sfxSounds; // nhac nen va nhac sfx
    public AudioSource musicSource, sfxSource; // nguon

    // tao cac gia tri ban dau
    private void Awake()
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
    }
    // Awake goi truoc ham Start
    private void Start()
    {
        PlayMusic("Theme"); // chay nhac nen
    }

    public void PlayMusic(string name)
    {
        Sound s = Array.Find(musicSounds, x => x.name == name);
        if (s == null)
        {
            Debug.Log("Sound Not Found");
        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();
        }
    }
}
