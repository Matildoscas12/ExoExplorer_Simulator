using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scenes : MonoBehaviour
{
    public Button botaoParaMudar;
    public string cenaParaMudar;

    void Start()
    {
        botaoParaMudar.onClick.AddListener(MudarCena);
    }

    void MudarCena()
    {
        SceneManager.LoadScene(cenaParaMudar);
    }
}
