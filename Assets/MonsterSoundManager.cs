using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSoundManager : MonoBehaviour
{
    private AudioSource SRC;
    public AudioClip Chase;
    public AudioClip Attack;
    public AudioClip Die;
    // Use this for initialization
    void Start()
    {
        SRC = GetComponent<AudioSource>();
    }

    public void ChaseSound()
    {
        if (SRC.clip != Chase)
        {
            SRC.clip = Chase;
            SRC.Play();
            SRC.loop = true;
        }
       
    }
    public void AttackSound()
    {
        SRC.loop = false;
        SRC.clip = Attack;
        SRC.Play();
        
    }
    public void DieSound()
    {
        SRC.loop = false;
        SRC.clip = Die;
        SRC.Play();
    }
}