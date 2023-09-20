using UnityEngine;

public class UpdatePosition : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private float _yPosition;

    public float YPosition
    {
        get => _yPosition;
        set => _yPosition = value;
    }

    private void OnDisable()
    {
        SetPosition();
    }
    
    public void SetPosition()
    {
        Vector3 pos = new Vector3(_target.transform.position.x, _yPosition, _target.transform.position.z);

        _target.transform.position = pos;
    }
}
