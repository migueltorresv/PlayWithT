using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderingMaskCamera : MonoBehaviour
{
    [SerializeField] private LayerMask layerMaskCameraToRender;
    [SerializeField] private Camera camera;

    public void ChangeLayerMaskToRender()
    {
        camera.cullingMask = layerMaskCameraToRender;
    }
}
