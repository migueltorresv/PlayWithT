using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTouchRobot : MonoBehaviour
{
    [SerializeField] private Material _materialToChange;
    [SerializeField] private List<Renderer> _skinnedMeshRenderers;
    [SerializeField] private List<Material> _materialsBefore;
    
    public void ChangeMaterial()
    {
        foreach (var skin in _skinnedMeshRenderers)
        {
            _materialsBefore.Add(skin.material);
        }

        foreach (var skin in _skinnedMeshRenderers)
        {
            skin.material = _materialToChange;
        }
    }

    public void ReturnMaterialOld()
    {
        int index = 0;
        foreach (var material in _materialsBefore)
        {
            _skinnedMeshRenderers[index].material = material;
            index++;
        }
    }

    public void CleanMaterialsBefore()
    {
        _materialsBefore.Clear();
    }
}
