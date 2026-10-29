using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotoesVel : MonoBehaviour
{
    public Slider slider;
    public Button setValueZeroButton;
    public Button setValueTwoButton;

    void Start()
    {
        // Define o callback do botão para definir o valor do slider como 0
        setValueZeroButton.onClick.AddListener(() => SetSliderValue(0));

        // Define o callback do botão para definir o valor do slider como 2
        setValueTwoButton.onClick.AddListener(() => SetSliderValue(2));
    }

    // Método para definir o valor do slider
    void SetSliderValue(float value)
    {
        slider.value = value;
    }
}
