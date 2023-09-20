using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WayPoint : MonoBehaviour
{
    [SerializeField] private UnityEvent OnHandUserEnter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("HandUserWP"))
        {
            OnHandUserEnter?.Invoke();
        }
    }

    public void MensajeTest()
    {
        Debug.Log("mensaje de prueba");
    }
}
