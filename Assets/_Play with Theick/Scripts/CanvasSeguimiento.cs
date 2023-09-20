using UnityEngine;

public class CanvasSeguimiento : MonoBehaviour
{
    [SerializeField] private Transform objetivo;

    [SerializeField] private Transform objetivoAMirar;
    
    [SerializeField] private float velocidadMovimientoSuave = 0.005f;
    private float distance;
    private Vector3 posicionSuavizada;
    private Vector3 posicionTemporal;
    [SerializeField] private float distanciaLimite = 0.3f;
    private void Start()
    {
        gameObject.GetComponentInChildren<Canvas>().transform.Rotate(0,180,0);
        posicionSuavizada = transform.position;
    }

    private void FixedUpdate()
    {
        SeguirObjetivo();
        posicionSuavizada = Vector3.Lerp(transform.position, posicionTemporal, velocidadMovimientoSuave);
        distance = Vector3.Distance(objetivo.position, transform.position);
    }

    private void LateUpdate()
    {
        transform.position = posicionSuavizada;
        transform.LookAt(objetivoAMirar);
    }

    public void MostrarCanvasMensaje()
    {
        gameObject.SetActive(true);
    }

    public void OcultarCanvasMensaje()
    {
        gameObject.SetActive(false);
    }

    private void SeguirObjetivo()
    {
        if (distance > distanciaLimite) 
            posicionTemporal = objetivo.position;
        else
            posicionTemporal = transform.position;
    }
}
