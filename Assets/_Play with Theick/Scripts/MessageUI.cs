using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MessageUI : MonoBehaviour
{
    [SerializeField] private float _timeForShowText = 5;
    [SerializeField] private UnityEvent OnStartMessage;
    [SerializeField] private UnityEvent OnTimeShowMessageFinished;
    [SerializeField] private UnityEvent OnDisableMessage;

    private void Start()
    {
        StartCoroutine(TimeShowMessageRoutine());
    }

    private IEnumerator TimeShowMessageRoutine()
    {
        OnStartMessage?.Invoke();
        yield return new WaitForSeconds(_timeForShowText);
        OnTimeShowMessageFinished?.Invoke();
    }

    private void OnDisable()
    {
        OnDisableMessage?.Invoke();
    }
}
