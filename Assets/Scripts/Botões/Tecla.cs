using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tecla : MonoBehaviour
{
    public GameObject painelE;
    public GameObject painelA;
    public GameObject painelP;
    public GameObject painelH1;
    public GameObject painelH2;
    public GameObject painelC;

    private bool painelHAtivo = false;

    void Update()
    {
        // Ativar painel ao pressionar a tecla E
        if (Input.GetKeyDown(KeyCode.E))
        {
            AtivarPainel(painelE);
        }

        // Ativar painel ao pressionar a tecla A
        if (Input.GetKeyDown(KeyCode.A))
        {
            AtivarPainel(painelA);
        }

        // Ativar painel ao pressionar a tecla P
        if (Input.GetKeyDown(KeyCode.P))
        {
            AtivarPainel(painelP);
        }

        // Alternar visibilidade dos painéis ao pressionar a tecla H
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (painelHAtivo)
            {
                EsconderPainel(painelH1);
                EsconderPainel(painelH2);
                painelHAtivo = false;
            }
            else
            {
                AtivarPainel(painelH1);
                AtivarPainel(painelH2);
                painelHAtivo = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            AtivarPainel(painelC);
        }
    }

    // Função para ativar o painel desejado e desativar os outros
    void AtivarPainel(GameObject painel)
    {
        painel.SetActive(true);

        if (painel != painelE)
        {
            painelE.SetActive(false);
        }
        if (painel != painelA)
        {
            painelA.SetActive(false);
        }
        if (painel != painelP)
        {
            painelP.SetActive(false);
        }
        if (painel != painelC)
        {
            painelC.SetActive(false);
        }
    }

    // Função para esconder o painel desejado
    void EsconderPainel(GameObject painel)
    {
        painel.SetActive(false);
    }
}
