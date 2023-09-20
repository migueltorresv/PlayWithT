using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorMaterial : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRendererToChange;
    [SerializeField] private Material _materialToChange;

    public void ChangeMaterial()
    {
        _meshRendererToChange.material = _materialToChange;
    }
}
