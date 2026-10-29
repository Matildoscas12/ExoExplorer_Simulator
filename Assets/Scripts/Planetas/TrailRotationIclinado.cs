using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailRotationIclinado : MonoBehaviour
{
    public Transform centerPoint; // Ponto central ao redor do qual a órbita ocorrerá
    public float orbitPeriodInDays = 1f; // Período orbital em dias
    public float orbitRadius = 2f; // Raio da órbita
    public float inclinationAngle = 30f; // Ângulo de inclinação da órbita em graus
    public float orbitSpeedMultiplier = 1f; // Multiplicador de velocidade da órbita

    private float angle = 0f;

    void Start()
    {
        // Calcula a posição inicial na órbita com base no tempo, raio e inclinação
        float initialX = centerPoint.position.x + orbitRadius * Mathf.Cos(angle);
        float initialY = centerPoint.position.y + orbitRadius * Mathf.Sin(angle) * Mathf.Sin(inclinationAngle * Mathf.Deg2Rad);
        float initialZ = centerPoint.position.z + orbitRadius * Mathf.Cos(inclinationAngle * Mathf.Deg2Rad) * Mathf.Sin(angle);

        // Define a posição inicial do objeto
        transform.position = new Vector3(initialX, initialY, initialZ);
    }

    void Update()
    {
        float orbitSpeed = 360f / (orbitPeriodInDays * 24f * 60f * 60f) * orbitSpeedMultiplier;
        angle += orbitSpeed * Time.deltaTime;

        // Calcula a posição na órbita com base no tempo, raio e inclinação
        float x = centerPoint.position.x + orbitRadius * Mathf.Cos(angle);
        float y = centerPoint.position.y + orbitRadius * Mathf.Sin(angle) * Mathf.Sin(inclinationAngle * Mathf.Deg2Rad);
        float z = centerPoint.position.z + orbitRadius * Mathf.Cos(inclinationAngle * Mathf.Deg2Rad) * Mathf.Sin(angle);

        // Atualiza a posição do objeto
        transform.position = new Vector3(x, y, z);
    }
}
