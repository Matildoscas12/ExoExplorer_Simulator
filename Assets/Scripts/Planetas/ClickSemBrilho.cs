using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickSemBrilho : MonoBehaviour
{
    public GameObject canvasObjeto;
    public GameObject[] paineisFilhos;

    private Renderer rend;

    void Start()
    {
        // Obtém o componente Renderer do objeto
        rend = GetComponent<Renderer>();

    }

    void OnMouseDown()
    {
        // Verifica se o Canvas está ativo ou não e alterna seu estado
        bool canvasAtivo = canvasObjeto.activeSelf;
        canvasObjeto.SetActive(!canvasAtivo);

        // Ativa ou desativa os painéis filhos de acordo com o estado do Canvas
        foreach (GameObject painel in paineisFilhos)
        {
            painel.SetActive(!canvasAtivo);
        }
    }
}
