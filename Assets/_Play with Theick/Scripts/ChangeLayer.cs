using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeLayer : MonoBehaviour
{
    [SerializeField] private XRGrabInteractable _grabInteractable;

    public void ChangeLayerGrabInteractable(int layerNumber)
    {
        StartCoroutine(WaitForChangeLayer(layerNumber));
    }

    private IEnumerator WaitForChangeLayer(int layerNUmber)
    {
        yield return null;
        var grabInteractLayer = _grabInteractable.interactionLayers;
        grabInteractLayer.value = layerNUmber;
        _grabInteractable.interactionLayers = grabInteractLayer;
    }
}
