﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    public Animator Animator { get { return (animator == null) ? animator = GetComponent<Animator>() : animator; } }

    Character character;
    Character Character { get { return (character == null) ? character = GetComponentInParent<Character>() : character; } }

    private void OnEnable()
    {
        if (Managers.Instance == null)
            return;

        


    }

    private void OnDisable()
    {
        if (Managers.Instance == null)
            return;

       
    }

    private void Update()
    {
        
    }

    private void UpdateAnimations()
    {
       
    }

    private void InvokeTrigger(string value)
    {
        
    }

    public void OnSlideFinish()
    {
        
    }

    public void OnJumpFinish()
    {
        
    }

    public void OnRunStart()
    {
        
    }
}
