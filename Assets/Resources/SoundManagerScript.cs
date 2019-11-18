using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip jumpSound, deadSound, coinSound;
    static AudioSource audioSrc;

    void Start()
    {
        jumpSound = Resources.Load<AudioClip>("jump");
        deadSound = Resources.Load<AudioClip>("dead");
        coinSound = Resources.Load<AudioClip>("coins");
        audioSrc = GetComponent<AudioSource>();
    }


    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip){
        case "jump":
                audioSrc.PlayOneShot (jumpSound);
                break;
        case "dead":
                audioSrc.PlayOneShot(deadSound);
                break;
        case "coins":
                audioSrc.PlayOneShot(coinSound);
                break;

        }
    }



}
