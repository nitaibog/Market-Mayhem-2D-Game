using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicControoler : MonoBehaviour
{



    public AudioMixer audioMixer;
    public AudioSource audioSource;
    public AudioSource[] audioEffectsarray;


    public void onChangeSlider(float value)
    {
        if (value != 0)
        {
            audioMixer.SetFloat("Volume", Mathf.Log10(value) * 20);
            PlayerPrefs.SetFloat("Volume", value);
            PlayerPrefs.Save();
        }
        else
        {
            audioMixer.SetFloat("Volume", -80);
            PlayerPrefs.SetFloat("Volume", value);
            PlayerPrefs.Save();
        }


    }
    private void Awake()
    {
        audioSource.volume = 1;
    }
    private void Start()
    {

        audioMixer.SetFloat("Volume", Mathf.Log10(PlayerPrefs.GetFloat("Volume", 1) * 20));
        while(true)
            Invoke("ActivateSoundEffect", Random.Range(3, 6));
    }

    
    void ActivateSoundEffect()
    {
        audioEffectsarray[Random.Range(0, 2)].Play();
    }
}
