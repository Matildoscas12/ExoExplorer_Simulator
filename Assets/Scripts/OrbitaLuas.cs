using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaLuas : MonoBehaviour
{
    public Transform centerPoint; // Ponto central ao redor do qual a órbita ocorrerá
    public float orbitPeriodInDays = 1f; // Período orbital em dias
    public float orbitRadius = 2f; // Raio da órbita
    public float inclinationAngle = 30f; // Ângulo de inclinação da órbita em graus

    private float angle = 0f;

    void Start()
    {
       
    }

    void Update()
    {

            float orbitSpeed = 360f / (orbitPeriodInDays * 24f * 60f * 60f);
            angle += orbitSpeed * Time.deltaTime;

            // Calcula a posição na órbita com base no tempo, raio e inclinação
            float x = centerPoint.position.x + orbitRadius * Mathf.Cos(angle);
            float y = centerPoint.position.y + orbitRadius * Mathf.Sin(angle) * Mathf.Sin(inclinationAngle * Mathf.Deg2Rad);
            float z = centerPoint.position.z + orbitRadius * Mathf.Cos(inclinationAngle * Mathf.Deg2Rad) * Mathf.Sin(angle);

            // Atualiza a posição do objeto
            transform.position = new Vector3(x, y, z);

    }
}
