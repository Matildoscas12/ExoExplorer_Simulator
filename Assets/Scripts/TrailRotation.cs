using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRotation : MonoBehaviour
{
    public Transform centerMass;
    public float rotationAroundSunDays = 1.0f;
    public float defaultEarthYear = 365.25f;

    // Update is called once per frame
    void Update()
    {
        if (centerMass != null)
        {
            // Aqui é onde apenas a velocidade constante é atualizada para o trail renderer
            transform.RotateAround(centerMass.position, Vector3.up, Time.deltaTime * (defaultEarthYear / rotationAroundSunDays));
        }
    }
}
