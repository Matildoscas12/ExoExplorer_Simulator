using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeguirPlaneta : MonoBehaviour
{
    public Transform target; // Objeto a ser seguido pela câmera
    public Camera mainCamera; // Referência para a câmera principal
    public float smoothSpeed = 0.125f; // Velocidade de suavização do movimento da câmera
    public float distance = 10f; // Distância da câmera em relação ao objeto

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Verifica se o botão esquerdo do mouse foi clicado
        {
            // Verifica se o clique ocorreu sobre este botão
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
            {
                // Calcula a posição desejada da câmera
                Vector3 desiredPosition = target.position - mainCamera.transform.forward * distance;
                // Interpola suavemente entre a posição atual da câmera e a posição desejada
                Vector3 smoothedPosition = Vector3.Lerp(mainCamera.transform.position, desiredPosition, smoothSpeed);
                // Atualiza a posição da câmera
                mainCamera.transform.position = smoothedPosition;
            }
        }
    }
}
