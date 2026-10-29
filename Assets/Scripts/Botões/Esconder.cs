using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Esconder : MonoBehaviour
{
    public List<GameObject> paineisParaAlternar;
    public Button botao;

    private void Start()
    {
        botao.onClick.AddListener(AlternarAtivacaoDosPaineis);
        foreach (GameObject painel in paineisParaAlternar)
        {
            painel.SetActive(true);
        }
    }

    public void AlternarAtivacaoDosPaineis()
    {
        foreach (GameObject painel in paineisParaAlternar)
        {
            painel.SetActive(!painel.activeSelf);
        }
    }
}
