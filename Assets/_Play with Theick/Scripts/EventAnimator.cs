using UnityEngine;

public class EventAnimator : MonoBehaviour
{
    [SerializeField] private Animator _animator1;
    [SerializeField] private Animator _animator2;
    [SerializeField] private string _nextAnimation;

    public Animator Animator1
    {
        get => _animator1;
        set => _animator1 = value;
    }

    public Animator Animator2
    {
        get => _animator1;
        set => _animator1 = value;
    }
    public string NextAnimation
    {
        get => _nextAnimation;
        set => _nextAnimation = value;
    }

    public void ActivateAnimationTrigger1(string nameTrigger)
    {
        _animator1.SetTrigger(nameTrigger);
    }

    public void ActiveAnimationBool1(string nameBool)
    {
        _animator1.SetBool(nameBool, true);
    }
    
    public void DeactiveAnimationBool1(string nameBool)
    {
        _animator1.SetBool(nameBool, false);
    }
    
    public void ActivateAnimationTrigger2(string nameTrigger)
    {
        _animator2.SetTrigger(nameTrigger);
    }

    public void ActiveAnimationBool2(string nameBool)
    {
        _animator2.SetBool(nameBool, true);
    }
    
    public void DeactiveAnimationBool2(string nameBool)
    {
        _animator2.SetBool(nameBool, false);
    }

    public void EndAnimation()
    {
        _animator1.SetTrigger(NextAnimation);
    }

    public void ClearNameNextAnimation()
    {
        _nextAnimation = "";
    }
}
