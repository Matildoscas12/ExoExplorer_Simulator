using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SairSimulador : MonoBehaviour
{
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(Quit);
    }

    void Quit()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }
}
