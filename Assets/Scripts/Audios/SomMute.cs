using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SomMute : MonoBehaviour
{
    public Sprite soundOnSprite;
    public Sprite soundOffSprite;
    public AudioSource backgroundMusic;
    private Image buttonImage;
    private bool isMuted = false;

    void Start()
    {
        buttonImage = GetComponent<Image>();
        UpdateButtonImage();
    }

    public void ToggleSound()
    {
        isMuted = !isMuted;

        if (isMuted)
        {
            backgroundMusic.mute = true;
        }
        else
        {
            backgroundMusic.mute = false;
        }
        UpdateButtonImage();
    }

    private void UpdateButtonImage()
    {
        if (isMuted)
        {
            buttonImage.sprite = soundOffSprite;
        }
        else
        {
            buttonImage.sprite = soundOnSprite;
        }
    }
}
