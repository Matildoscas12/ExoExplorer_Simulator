using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class configExibText : MonoBehaviour
{
    public Button showButton;
    public Button hideButton;
    public Color selectedColor;
    public Color originalColor;
    public List<TextMeshPro> textMeshProsToHide;

    private List<bool> textMeshProsStates; // Armazena o estado de visibilidade dos TextMeshPro

    void Start()
    {
        // Configura o botão "Mostrar" como selecionado no início
        showButton.image.color = selectedColor;
        hideButton.image.color = originalColor;

        // Armazena o estado de visibilidade inicial dos TextMeshPro
        textMeshProsStates = new List<bool>();
        foreach (TextMeshPro textMeshPro in textMeshProsToHide)
        {
            textMeshProsStates.Add(textMeshPro.enabled);
        }

        // Associa as funções de clique aos botões
        showButton.onClick.AddListener(ShowTextMeshPros);
        hideButton.onClick.AddListener(HideTextMeshPros);
    }

    void ShowTextMeshPros()
    {
        // Ativa todos os TextMeshPro na lista
        for (int i = 0; i < textMeshProsToHide.Count; i++)
        {
            textMeshProsToHide[i].enabled = true;
        }

        // Muda as cores dos botões
        showButton.image.color = selectedColor;
        hideButton.image.color = originalColor;
    }

    void HideTextMeshPros()
    {
        // Desativa todos os TextMeshPro na lista
        for (int i = 0; i < textMeshProsToHide.Count; i++)
        {
            textMeshProsToHide[i].enabled = false;
        }

        // Muda as cores dos botões
        showButton.image.color = originalColor;
        hideButton.image.color = selectedColor;
    }
}
