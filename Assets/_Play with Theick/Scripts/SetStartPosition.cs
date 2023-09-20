using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SetStartPosition : MonoBehaviour
{
    [SerializeField] private Transform _gameObject;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private Vector3 _startRotation;
    [SerializeField] private float _timeDelayForStartEvent;
    [SerializeField] private UnityEvent OnTransformRestarted;

    private void SetPosition()
    {
        _gameObject.transform.position = _startPosition;
    }

    private void SetRotation()
    {
        _gameObject.rotation = Quaternion.Euler(-_startRotation);
    }

    public void SetPositionAndRotation()
    {
        SetPosition();
        SetRotation();
        StartCoroutine(TransformRestartRoutine());
    }

    private IEnumerator TransformRestartRoutine()
    {
        yield return new WaitForSeconds(_timeDelayForStartEvent);
        OnTransformRestarted?.Invoke();
    }
}
