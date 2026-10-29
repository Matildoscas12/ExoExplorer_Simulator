using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelManager : MonoBehaviour
{
    public GameObject[] panels;

    public void ShowPanel(int panelIndex)
    {
        // Verifica se o painel está ativo
        bool isActive = panels[panelIndex].activeSelf;

        // Desativa todos os painéis
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
        }

        // Se o painel não estava ativo, ativá-lo
        if (!isActive)
        {
            panels[panelIndex].SetActive(true);
        }
    }
}
