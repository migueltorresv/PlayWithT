using UnityEngine;
using UnityEngine.Events;

public class Point : MonoBehaviour
{
    [SerializeField] private string _triggerName;
    [SerializeField] private bool _canUseTrigger = false;

    [Space] 
    [SerializeField] private string _boolName;
    [SerializeField] private bool isActiveBool;
    
    [Space]
    [SerializeField] private UnityEvent OnDisableObject;

    public string TriggerName
    {
        get => _triggerName;
        set => _triggerName = value;
    }

    public bool CanUseTrigger
    {
        get => _canUseTrigger;
        set => _canUseTrigger = value;
    }
    
    public string BoolName
    {
        get => _boolName;
        set => _boolName = value;
    }

    public bool IsActiveBool
    {
        get => isActiveBool;
        set => isActiveBool = value;
    }

    private void OnDisable()
    {
        OnDisableObject?.Invoke();
    }
}
