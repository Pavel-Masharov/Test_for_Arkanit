using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Script_ButtonController : MonoBehaviour
{
    public AudioClip _clickSound;
    private AudioSource _mainAudio;
    void Start()
    {
        _mainAudio = GetComponent<AudioSource>();
    }

    public void SoundOnClick()
    {
        _mainAudio.PlayOneShot(_clickSound, 1f);
    }
}
