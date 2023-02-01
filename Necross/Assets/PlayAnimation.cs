using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour
{
    public Animator anim;
    public string animName;

    public void PlayAnim()
    {
        anim.Play(animName);
    }
}
