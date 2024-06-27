using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PowerButton : MonoBehaviour
{
    private const string MasterMixerParametre = "Master";

    [SerializeField] private float _offVolumeValue;
    [SerializeField] private float _onVolumeValue;
    [SerializeField] private AudioMixer _audioMixer;
    [SerializeField] private Button _button;

    private void OnEnable()
    {
        _button.onClick.AddListener(SwitchPower);
        _audioMixer.SetFloat(MasterMixerParametre, 0);

    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(SwitchPower);
    }

    private bool _enabled = true;

    private void SwitchPower()
    {
        if (_enabled)
        {
            _audioMixer.SetFloat(MasterMixerParametre, _offVolumeValue);
            _enabled = false;
        }
        else
        {
            _enabled = true;
            _audioMixer.SetFloat(MasterMixerParametre, _onVolumeValue);
        }
    }

}
