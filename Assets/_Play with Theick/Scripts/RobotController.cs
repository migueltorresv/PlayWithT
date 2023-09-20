using System;
using UnityEngine;
using UnityEngine.Events;

public class RobotController : MonoBehaviour
{
    [SerializeField] private EventAnimator _eventAnimator;
    [SerializeField] private UnityEvent OnTriggerEnterRampa;
    [SerializeField] private UnityEvent OnTriggerEnterPositionUser;
    [SerializeField] private UnityEvent OnTriggerEnterRampaConsecutiva;
    [SerializeField] private UnityEvent OnTriggerEnterHandUser;
    [SerializeField] private UnityEvent OnTriggerExitHandUser;
    [SerializeField] private UnityEvent OnTriggerFinal;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rampa"))
        {
            OnTriggerEnterRampa?.Invoke();
            other.enabled = false;
        }

        if (other.gameObject.CompareTag("PositionUser"))
        {
            OnTriggerEnterPositionUser?.Invoke();
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("Point"))
        {
            string triggerName = other.GetComponent<Point>().TriggerName;
            bool canUseTrigger = other.GetComponent<Point>().CanUseTrigger;
            if (canUseTrigger)
            {
                _eventAnimator.Animator1.SetTrigger(triggerName);
            }
            else
            {
                string boolName = other.GetComponent<Point>().BoolName;
                bool isActive = other.GetComponent<Point>().IsActiveBool;
                _eventAnimator.Animator1.SetBool(boolName, isActive);
            }

            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("RampaA"))
        {
            OnTriggerEnterRampaConsecutiva?.Invoke();
            other.enabled = false;
        }
        
        if (other.gameObject.CompareTag("RampaB"))
        {
            _eventAnimator.NextAnimation = other.GetComponent<Rampa>().NameTriggerAnim;
            other.enabled = false;
        }

        if (other.gameObject.CompareTag("HandUser"))
        {
            OnTriggerEnterHandUser?.Invoke();
        }

        if (other.gameObject.CompareTag("Final"))
        {
            OnTriggerFinal?.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("HandUser"))
        {
            OnTriggerExitHandUser?.Invoke();
        }
    }
}
