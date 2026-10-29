using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class idletra : MonoBehaviour
{
    public Transform target; // O objeto que a câmera está mirando
    public TextMeshPro[] textMeshProList; // Lista de TextMeshPro
    public float initialDistance = 441f; // Distância inicial da câmera ao texto
    public float maxTextSize = 100f; // Tamanho máximo do texto
    public float minTextSize = 10f; // Tamanho mínimo do texto
    public float sizeMultiplier = 0.1f; // Fator de multiplicação para ajustar o tamanho do texto

    private float[] initialFontSizes; // Tamanho inicial do texto

    void Start()
    {
        // Inicializa o array de tamanhos iniciais do texto
        initialFontSizes = new float[textMeshProList.Length];
        for (int i = 0; i < textMeshProList.Length; i++)
        {
            initialFontSizes[i] = textMeshProList[i].fontSize;
        }
    }

    void Update()
    {
        // Calcula a distância entre a câmera e o objeto mirado
        float distance = Vector3.Distance(transform.position, target.position);

        // Calcula o tamanho do texto para cada TextMeshPro na lista
        for (int i = 0; i < textMeshProList.Length; i++)
        {
            // Calcula o novo tamanho do texto com base na distância
            float newSize = initialFontSizes[i] + (distance - initialDistance) * sizeMultiplier;

            // Limita o tamanho do texto dentro do intervalo definido
            newSize = Mathf.Clamp(newSize, minTextSize, maxTextSize);

            // Atualiza o tamanho do texto
            textMeshProList[i].fontSize = newSize;
        }
    }
}
