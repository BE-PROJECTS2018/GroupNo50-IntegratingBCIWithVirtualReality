using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    private AudioSource SRC;
    public AudioClip Footstep;
    public AudioClip Portal;
    public AudioClip Shoot;
    private void Start()
    {
        SRC = GetComponent<AudioSource>();
    }
    public void ShootSound()
    {
        SRC.Stop();
        SRC.pitch = 1;
        SRC.clip = Shoot;
        SRC.Play();
        SRC.loop = false;

    }
    public void PortalSound(float pitch)
    {
        SRC.Stop();
        SRC.pitch = pitch;
        SRC.clip = Portal;
        SRC.Play();
        SRC.loop = true;
    }
    public void FootStepSound()
    {
        SRC.Stop();
        SRC.pitch = 1;
        SRC.clip = Footstep;
        SRC.Play();
        SRC.loop = false;
    }
}
