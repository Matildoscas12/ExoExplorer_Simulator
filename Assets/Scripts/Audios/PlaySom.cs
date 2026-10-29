using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySom : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;
    public Button playPauseButton;

    private bool isPlaying = false;

    void Start()
    {
        slider.maxValue = audioSource.clip.length;
        slider.value = 0f;
        playPauseButton.onClick.AddListener(TogglePlayPause);
    }

    void Update()
    {
        if (isPlaying)
        {
            slider.value = audioSource.time;
        }
    }

    void TogglePlayPause()
    {
        if (!isPlaying)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
        isPlaying = !isPlaying;
    }

    public void Stop()
    {
        audioSource.Stop();
        isPlaying = false;
        slider.value = 0f;
    }
}
