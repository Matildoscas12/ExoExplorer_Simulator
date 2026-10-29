using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomBotao : MonoBehaviour
{
    // Referência ao componente AudioSource
    private AudioSource audioSource;

    void Start()
    {
        // Obtém a referência ao componente AudioSource do GameObject
        audioSource = GetComponent<AudioSource>();

        // Garante que o AudioSource foi encontrado
        if (audioSource == null)
        {
            Debug.LogError("O componente AudioSource não foi encontrado neste GameObject.");
        }
    }

    // Método chamado quando o botão é clicado
    public void TocarSom()
    {
        // Verifica se há um AudioSource
        if (audioSource != null)
        {
            // Toca o som
            audioSource.Play();
        }
        else
        {
            Debug.LogError("O componente AudioSource não foi atribuído neste GameObject.");
        }
    }
}
