using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
#if UNITY_EDITOR
    [Range(0,5)]
    [SerializeField] private float _gameSpeed;
#endif
    [SerializeField] private UnityEvent OnStartGame;

    private void Start()
    {
        OnStartGame?.Invoke();
    }
#if UNITY_EDITOR
    private void Update()
    {
        Time.timeScale = _gameSpeed;
    }
#endif
    public void MensajeTest()
    {
        Debug.Log("mensaje recibido");
    }
    
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
