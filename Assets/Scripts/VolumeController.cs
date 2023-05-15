using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider BGMSlider, UISlider;

    private void Start()
    {
        // Load Value Slider
        BGMSlider.value = PlayerPrefs.GetFloat("bgmSlider");
        UISlider.value = PlayerPrefs.GetFloat("uiSlider");
    }

    public void SetBGMVolume()
    {
        //Adjust Volume By Slider
        float BGMVolume = Mathf.Log10(BGMSlider.value) * 20; // Mengikuti Metode Volume Mixer yang Logarithmic
        audioMixer.SetFloat("bgm_vol", BGMVolume);

        //Save Slider Value by PlayerPref
        PlayerPrefs.SetFloat("bgmSlider", BGMSlider.value);
    }

    public void SetUIVolume()
    {
        //Adjust Volume By Slider
        float UIVolume = Mathf.Log10(UISlider.value) * 20; // Mengikuti Metode Volume Mixer yang Logarithmic
        audioMixer.SetFloat("ui_vol", UIVolume);

        //Save Slider Value by PlayerPref
        PlayerPrefs.SetFloat("uiSlider", UISlider.value);
    }
}
