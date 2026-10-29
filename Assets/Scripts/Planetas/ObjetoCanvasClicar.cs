using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoCanvasClicar : MonoBehaviour
{
    public Material materialOriginal;
    public Material materialHover;
    public GameObject canvasObjeto;
    public GameObject[] paineisFilhos;
    private Renderer rend;
    private bool canvasAtivo = false;

    void Start()
    {
        rend = GetComponent<Renderer>();
        materialOriginal = rend.material;
    }

    void OnMouseEnter()
    {
        rend.material = materialHover;
    }

    void OnMouseExit()
    {
        rend.material = materialOriginal;
    }

    void OnMouseDown()
    {
        canvasAtivo = !canvasAtivo;
        canvasObjeto.SetActive(canvasAtivo);
        foreach (GameObject painel in paineisFilhos)
        {
            painel.SetActive(canvasAtivo);
        }
    }
}
