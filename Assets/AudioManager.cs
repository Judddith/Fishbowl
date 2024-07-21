using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip ambience;
    public AudioClip music;
    public AudioClip menuButton;
    public AudioClip drag;
    public AudioClip drop;

    private void Start()
    {
        
        musicSource.clip = ambience;
        musicSource.Play();
    }
    
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
