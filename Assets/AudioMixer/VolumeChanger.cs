using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour
{
    [SerializeField] private string _parametreName;
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Slider _slider;

    private void Start()
    {
        SetMusicVolume();
    }

    public void SetMusicVolume()
    {
        float volume = _slider.value;
        _audioMixer.SetFloat(_parametreName, volume);
    }
}
