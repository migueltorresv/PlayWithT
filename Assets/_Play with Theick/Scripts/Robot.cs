using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private void Start()
    {
        
    }

    public void SetFloatXParameter(float value)
    {
        animator.SetFloat("X", value);
    }

    public void SetFloatYParameter(float value)
    {
        animator.SetFloat("Y", value);
    }

    public void GoToBall()
    {
        
    }
    
}
