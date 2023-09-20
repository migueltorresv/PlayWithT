using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

[CreateAssetMenu (fileName = "Sfx", menuName = "ScriptableObjects/CreateNewAssetSfx")]
public class AudioSfx : ScriptableObject
{
    [Serializable]
    public struct AudioParametersStruct
    {
        public string AudioName;
        public AudioClip[] audioClips;
        public float Volume;
        public float Pitch;
        public bool Loop;
        public float StartDelay;
    }

    public AudioParametersStruct AudioParameters;
    private AudioSource _audioSource;
    private GameObject _gameObject;

    public void PlayAudio()
    {
        if (_gameObject == null)
        {
            _gameObject = new GameObject($"Audio {AudioParameters.AudioName}");
            _gameObject.AddComponent<AudioSource>();
            _audioSource = _gameObject.GetComponent<AudioSource>();
        }
        
        _audioSource.clip = AudioParameters.audioClips[Random.Range(0, AudioParameters.audioClips.Length)];
        _audioSource.volume = AudioParameters.Volume;
        _audioSource.pitch = AudioParameters.Pitch;
        _audioSource.loop = AudioParameters.Loop;
        _audioSource.PlayDelayed(AudioParameters.StartDelay);
    }

    public void StopAudio()
    {
        _audioSource.Stop();
    }
}
