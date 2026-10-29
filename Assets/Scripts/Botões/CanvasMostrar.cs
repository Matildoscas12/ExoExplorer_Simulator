using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasMostrar : MonoBehaviour
{
    public GameObject[] canvas;
    public GameObject canvasatual;
    public Button botao;

    void Start()
    {
        foreach(GameObject canvas in canvas)
        {
            if(canvas != canvasatual)
            { 
                canvas.SetActive(false); 
            }
        }

        botao.onClick.AddListener(MostrarCanvas);
    }

    // Update is called once per frame
    public void MostrarCanvas()
    {
        canvasatual.SetActive(true);

        foreach (GameObject canvas in canvas)
        {
            if (canvas != canvasatual)
            {
                canvas.SetActive(false);
            }
        }
    }
}
