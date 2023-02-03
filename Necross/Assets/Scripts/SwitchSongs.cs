using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSongs : MonoBehaviour
{
    public AudioSource audSr;
    public List<AudioClip> clips;
    public UnityEngine.UI.Slider slider;
    public int num = 0;
    void Update()
    {
        audSr.volume = slider.value;
    }
}
