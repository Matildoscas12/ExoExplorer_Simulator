using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    public Canvas canvasParaAtivar;
    public Button button;

    void Start()
    {
        canvasParaAtivar.gameObject.SetActive(false);
        button.onClick.AddListener(AtivarCanvasComBotao);
    }

    public void AtivarCanvasComBotao()
    {
        if (canvasParaAtivar.gameObject.activeSelf)
        {
            canvasParaAtivar.gameObject.SetActive(false);
        }
        else
        {
            canvasParaAtivar.gameObject.SetActive(true);
        }
    }
}
