using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBar;
    public float fillSpeed = 0.5f; // Ajuste esta variável para controlar a velocidade de preenchimento da barra de progresso

    public void LoadScene(int sceneId)
    {
        StartCoroutine(LoadSceneAsync(sceneId));
    }

    IEnumerator LoadSceneAsync(int sceneId)
    {
        LoadingScreen.SetActive(true);

        yield return new WaitForSeconds(1.0f); // Atraso antes de iniciar o carregamento

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);

        while (!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);
            LoadingBar.fillAmount += fillSpeed * Time.deltaTime; // Atualize a barra de progresso gradualmente
            yield return null;
        }
    }
}
