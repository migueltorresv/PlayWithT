using UnityEngine;
using UnityEngine.Events;

public class PositionUser : MonoBehaviour
{
    [SerializeField] private UnityEvent OnDisbleObject;

    private void OnDisable()
    {
        OnDisbleObject?.Invoke();
    }
}
