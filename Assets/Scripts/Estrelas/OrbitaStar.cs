using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaStar : MonoBehaviour
{
    public Transform object1; // Primeiro objeto
    public Transform object2; // Segundo objeto
    public float orbitSpeed = 10f; // Velocidade da órbita (graus por segundo)
    public float semiMajorAxis = 3f; // Semi-eixo maior da elipse
    public float eccentricity = 0.5f; // Excentricidade da elipse

    private Vector3 orbitCenter; // Ponto central entre os dois objetos

    void Start()
    {
        if (object1 == null || object2 == null)
        {
            Debug.LogError("Por favor, atribua os objetos para orbitar.");
            enabled = false;
            return;
        }

        // Calcula o ponto central entre os dois objetos
        orbitCenter = (object1.position + object2.position) / 2f;
    }

    void Update()
    {
        // Move o ponto central conforme os objetos se movem
        orbitCenter = (object1.position + object2.position) / 2f;

        // Limita o valor de eccentricity entre 0 e 1
        eccentricity = Mathf.Clamp(eccentricity, 0f, 1f);

        // Calcula a posição ao longo da elipse
        float angle = Time.time * orbitSpeed * Mathf.Deg2Rad;
        float x = semiMajorAxis * Mathf.Cos(angle);
        float y = Mathf.Sqrt(Mathf.Max(1 - Mathf.Pow(eccentricity, 2), 0)) * semiMajorAxis * Mathf.Sin(angle);

        // Define a posição dos objetos
        object1.position = orbitCenter + new Vector3(x, 0, y);
        object2.position = orbitCenter - new Vector3(x, 0, y);
    }
}
