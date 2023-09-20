using UnityEngine;
using UnityEngine.Events;

public class SphereColliderRobot : MonoBehaviour
{
    [SerializeField] private UnityEvent OnTriggerHandUserEnter;
    [SerializeField] private UnityEvent OnTriggerHandUserExit;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("HandUser"))
        {
            OnTriggerHandUserEnter?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HandUser"))
        {
            OnTriggerHandUserExit?.Invoke();
        }
    }
}
