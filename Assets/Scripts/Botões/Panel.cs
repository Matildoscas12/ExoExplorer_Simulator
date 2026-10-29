using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject panelParaAtivar;
    public Button button;

    void Start()
    {
        // Desativa o Canvas no início para garantir que ele não esteja visível no início
        panelParaAtivar.gameObject.SetActive(false);

        // Adiciona um listener ao botão para chamar o método AtivarCanvasComBotao quando clicado
        button.onClick.AddListener(AtivarCanvasComBotao);
    }

    public void AtivarCanvasComBotao()
    {
        if (panelParaAtivar.gameObject.activeSelf)
        {
            panelParaAtivar.gameObject.SetActive(false);
        }
        else
        {
            panelParaAtivar.gameObject.SetActive(true);
        }
    }
}
