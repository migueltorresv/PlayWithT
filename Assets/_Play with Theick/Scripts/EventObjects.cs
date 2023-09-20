using UnityEngine;

public class EventObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] _objects;

    public void EnableObjectByIndex(int index)
    {
        _objects[index].SetActive(true);
    }

    public void DesableObjectByIndex(int index)
    {
        _objects[index].SetActive(false);
    }
}
