using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSongs : MonoBehaviour
{
    public AudioSource audSr;
    public List<AudioClip> clips;
    public int num = 0;
    void Update()
    {
        if (audSr.isPlaying == false)
        {
            num = Random.Range(0, clips.Capacity);
            audSr.PlayOneShot(clips[num]);
        }
    }
}
