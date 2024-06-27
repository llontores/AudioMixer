using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private Button _button;

    private void Awake()
    {
        _audioSource.playOnAwake = false;
    }

    private void OnEnable()
    {
        _button.onClick.AddListener(PlaySoundOnClick);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(PlaySoundOnClick);
    }

    public void PlaySoundOnClick()
    {
        _audioSource.Play();
    }
}
