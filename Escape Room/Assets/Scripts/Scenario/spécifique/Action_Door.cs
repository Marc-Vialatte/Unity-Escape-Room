using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action_Door : MonoBehaviour
{

    public GameObject character;
    private Animator animator;
    private AudioSource audio;
    public float distance = 10f;

    private void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(character.transform.position, transform.position) <= distance)
        {
            animator.SetBool("character_nearby", true);
        }
        else
        {
            animator.SetBool("character_nearby", false);
            audio.Play();
        }
    }
}