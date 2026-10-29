using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class Texto : MonoBehaviour
{
    public TMP_Text textComponent;
    public Color startColor = Color.white;
    public Color endColor = Color.red;
    public float blinkSpeed = 1.0f;

    private bool isBlinking = true;
    private float t = 0.0f;

    void Start()
    {
        if (textComponent == null)
        {
            textComponent = GetComponent<TMP_Text>();
        }
        StartCoroutine(BlinkRoutine());
    }

    IEnumerator BlinkRoutine()
    {
        while (isBlinking)
        {
            textComponent.color = Color.Lerp(startColor, endColor, Mathf.PingPong(t, 1));
            t += Time.deltaTime * blinkSpeed;
            yield return null;
        }
    }
}
