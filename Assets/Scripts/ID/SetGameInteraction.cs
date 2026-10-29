using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetGameInteraction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool gameInteractionEnabled = true;

    public void OnPointerEnter(PointerEventData eventData)
    {
        gameInteractionEnabled = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameInteractionEnabled = true;
    }

    public bool IsGameInteractionEnabled()
    {
        return gameInteractionEnabled;
    }
}
