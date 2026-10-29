using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrocarCanvas : MonoBehaviour
{
    public Canvas canvasAtual;
    public Canvas proximoCanvas;
    public Button botao;

    private void Start()
    {
        // Adiciona o listener do botão
        botao.onClick.AddListener(Trocar);
    }

    // Método para trocar os canvases
    public void Trocar()
    {
        // Verifica se ambos os canvases são válidos
        if (canvasAtual != null && proximoCanvas != null)
        {
            // Desativa o canvas atual
            canvasAtual.gameObject.SetActive(false);
            // Ativa o próximo canvas
            proximoCanvas.gameObject.SetActive(true);
        }
    }
}
