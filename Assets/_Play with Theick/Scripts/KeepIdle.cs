using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepIdle : MonoBehaviour
{
    [SerializeField] private EventAnimator _eventAnimator;
    private void OnDisable()
    {
        _eventAnimator.DeactiveAnimationBool1("isWalking");
    }
}
