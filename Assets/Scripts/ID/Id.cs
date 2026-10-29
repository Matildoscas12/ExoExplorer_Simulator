using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Id : MonoBehaviour
{

    public TextMeshPro textMesh;
    public float aumentoPorDistancia = 10f;
    public float diminuicaoPorDistancia = 10f;
    public float distanciaInicialAumento = 30f;
    private float ultimaDistanciaAtualizada;

    void Start()
    {
        // Define a última distância atualizada como a distância inicial
        ultimaDistanciaAtualizada = Vector3.Distance(transform.position, Camera.main.transform.position);
    }

    void Update()
    {
        // Calcula a distância entre a câmera e o objeto
        float distancia = Vector3.Distance(transform.position, Camera.main.transform.position);

        // Verifica se a câmera se afastou o suficiente para aumentar o tamanho do texto
        if (distancia > ultimaDistanciaAtualizada + distanciaInicialAumento)
        {
            // Aumenta o tamanho do texto
            textMesh.fontSize += aumentoPorDistancia;

            // Atualiza a última distância atualizada
            ultimaDistanciaAtualizada = distancia;
        }
        // Verifica se a câmera se aproximou o suficiente para diminuir o tamanho do texto
        else if (distancia < ultimaDistanciaAtualizada - distanciaInicialAumento)
        {
            // Diminui o tamanho do texto
            textMesh.fontSize -= diminuicaoPorDistancia;

            // Atualiza a última distância atualizada
            ultimaDistanciaAtualizada = distancia;
        }

        // Desativa o TextMeshPro se o tamanho da fonte for menor que 2
        if (textMesh.fontSize < 5)
        {
            textMesh.gameObject.SetActive(false);
        }
        // Ativa o TextMeshPro se o tamanho da fonte for igual ou maior que 2
        else if (textMesh.fontSize >= 5)
        {
            textMesh.gameObject.SetActive(true);
        }

        // Obtém a direção da câmera
        Vector3 cameraDirection = Camera.main.transform.forward;

        // Mantém apenas a rotação em torno do eixo y
        Quaternion lookRotation = Quaternion.LookRotation(cameraDirection, Vector3.up);

        // Aplica a rotação ao objeto
        transform.rotation = lookRotation;
    }

}
