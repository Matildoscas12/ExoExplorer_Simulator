using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Velocidade de rotação do objeto
    public float selfRotationSpeed = 10f;

    void Update()
    {
        // Rotaciona o planeta em torno de seu próprio eixo
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);
    }
}
