using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Cena : MonoBehaviour
{
    public Button button; // Referência para o botão no Inspector
    public string sceneName; // Nome da cena a ser carregada

    void Start()
    {
        // Adiciona um listener para o clique no botão
        button.onClick.AddListener(LoadScene);
    }

    // Método chamado quando o botão é clicado
    private void LoadScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
