using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigExib : MonoBehaviour
{
    public Button showButton;
    public Button hideButton;
    public Color selectedColor;
    public Color originalColor;
    public List<GameObject> objectsToHide;

    void Start()
    {
        showButton.image.color = selectedColor;
        hideButton.image.color = originalColor;

        showButton.onClick.AddListener(ShowObjects);
        hideButton.onClick.AddListener(HideObjects);
    }

    void ShowObjects()
    {
        foreach (GameObject obj in objectsToHide)
        {
            if (obj != null)
                obj.SetActive(true);
        }
        showButton.image.color = selectedColor;
        hideButton.image.color = originalColor;
    }

    void HideObjects()
    {
        foreach (GameObject obj in objectsToHide)
        {
            if (obj != null)
                obj.SetActive(false);
        }
        showButton.image.color = originalColor;
        hideButton.image.color = selectedColor;
    }
}
