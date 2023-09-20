using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject ball;
    private Vector3 direction;
    
    
    
    private void Start()
    {
        CalculateDistancePitagoras();
    }

    /// <summary>
    /// Clase 2 - distancia
    /// Conocer la distancia entre 2 objetos es importante para calcular el ángulo normalizado entre 2 vectores
    /// Para calcular la distancia se usará el teorema de pitágoras -> h = √ (a)2 + (b)2 -> h = √ (x1-x2)2 + (y1-y2)2
    /// </summary>
    private void CalculateDistancePitagoras()
    {
        Vector3 posObjA = transform.position;
        Vector3 posObjB = ball.transform.position;
        float distance = Mathf.Sqrt(Mathf.Pow(posObjA.x-posObjB.x,2) + Mathf.Pow(posObjA.y-posObjB.y,2) + Mathf.Pow(posObjA.z-posObjB.z,2));
        Debug.Log($"Distancia: {distance}");
    }


    private void Update()
    {
        //MoveToObjectiveVectors();
    }
    
    // Clase 1- vectores, calcular la dirección para trasladar un objeto de un punto a otro
    private void MoveToObjectiveVectors()
    {
        direction = ball.transform.position - transform.position;
        transform.LookAt(ball.transform.position);
        if (direction.magnitude > 0.15f)
        {
            Vector3 velocity = direction.normalized * speed * Time.deltaTime;
            transform.Translate(velocity);
        }
    }
}
