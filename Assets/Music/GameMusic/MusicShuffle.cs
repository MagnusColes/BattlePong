using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicShuffle : MonoBehaviour
{
    public AudioSource myAudio;
    public AudioClip[] Musiclist; // declare this as Object array
 
     void Start()
    {
        playRandomMusic();
    }

    // Update is called once per frame
    void Update()
    {
        if (!myAudio.isPlaying)
            playRandomMusic();
    }

    void playRandomMusic()
    {
        myAudio.clip = Musiclist[Random.Range(0, Musiclist.Length)] as AudioClip;
        myAudio.Play();
    }

}
