using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocarImagem : MonoBehaviour
{
    public Sprite imagem1;
    public Sprite imagem2;

    private Image botaoImage;
    public Button botao;
    public Slider slider;
    private bool imagem1Ativa = true;

    void Start()
    {
        botaoImage = GetComponent<Image>();
        botao = GetComponent<Button>();
        botaoImage.sprite = imagem1;
        botao.onClick.AddListener(ButtonClick);
        slider.onValueChanged.AddListener(delegate { CheckSliderValue(); });
    }

    public void ButtonClick()
    {
        if (imagem1Ativa)
        {
            botaoImage.sprite = imagem2;
        }
        else
        {
            botaoImage.sprite = imagem1;
        }
        imagem1Ativa = !imagem1Ativa;
    }

    void CheckSliderValue()
    {
        if (slider.value == slider.maxValue)
        {
            slider.value = slider.minValue;
            botaoImage.sprite = imagem1;
            imagem1Ativa = true;
        }
    }
}
