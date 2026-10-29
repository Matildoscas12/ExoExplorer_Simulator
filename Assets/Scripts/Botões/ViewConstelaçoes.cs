using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewConstelaçoes : MonoBehaviour
{
    public Button showButton; // Botão para mostrar o novo skybox
    public Button hideButton; // Botão para esconder o novo skybox
    public Material originalSkybox; // Material do skybox original
    public Material newSkybox; // Material do novo skybox
    public Color selectedColor;
    public Color originalColor;

    void Start()
    {
        // Configura os eventos de clique para os botões
        showButton.onClick.AddListener(ShowNewSkybox);
        hideButton.onClick.AddListener(HideNewSkybox);

        // Define o skybox inicial
        RenderSettings.skybox = originalSkybox;

        showButton.image.color = originalColor;
        hideButton.image.color = selectedColor;
    }

    // Função para mostrar o novo skybox
    void ShowNewSkybox()
    {
        RenderSettings.skybox = newSkybox;
        showButton.image.color = selectedColor;
        hideButton.image.color = originalColor;
    }

    // Função para esconder o novo skybox
    void HideNewSkybox()
    {
        RenderSettings.skybox = originalSkybox;
        showButton.image.color = originalColor;
        hideButton.image.color = selectedColor;
    }
}
