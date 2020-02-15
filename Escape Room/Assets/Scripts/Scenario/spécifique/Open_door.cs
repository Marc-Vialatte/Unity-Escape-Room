using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_door : MonoBehaviour
{
    private Animator animator;
    private AudioSource audio;


    public void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        animator.SetBool("character_nearby", false);
    }

    public void Opendoor()
    {
        animator.SetBool("character_nearby", true);
        audio.Play();
    }
}
