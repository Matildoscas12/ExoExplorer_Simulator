using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Rotation around planet.
/// </summary>
public class RotationAroundPlanet : MonoBehaviour
{
    public Transform target;
    public float distance = 5f;

    // ZoomCameraMouse
    [SerializeField] public float MouseWheelSensitivity = 1;
    [SerializeField] private float moveSpeed = 5f;
    public float MouseZoomMin = 1.5f;

    public float xSpeed = 40.0f;
    public float ySpeed = 40.0f;

    private float x = 80.0f;
    private float y = 50.0f;

    public float minFov = 0.01f;
    public float maxFov = 179.9f;
    public float fovDefault = 60.0f;

    Quaternion rotation;
    Vector3 position;

    public bool isRotating;

    public List<SetGameInteraction> canvasInteractionControllers = new List<SetGameInteraction>();

    void Start()
    {
        Cursor.visible = true;

        var angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
        SetPosition();
    }

    void LateUpdate()
    {
        // Verifica se a interação com o jogo está habilitada em qualquer CanvasInteractionController
        bool gameInteractionEnabled = true;
        foreach (var canvasInteractionController in canvasInteractionControllers)
        {
            if (!canvasInteractionController.IsGameInteractionEnabled())
            {
                gameInteractionEnabled = false;
                break;
            }
        }

        // Apenas mova a câmera se a interação com o jogo estiver habilitada
        if (gameInteractionEnabled)
        {
            // Ignore UI Layer para não rotacionar ou rolar os planetas sobre a UI
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var raycast = Physics.Raycast(ray, 500, LayerMask.NameToLayer("UI"));

            SetPosition();

            if (Input.GetMouseButton(0)) // Verifica se o botão esquerdo do mouse está sendo pressionado
            {
                x += Input.GetAxis("Mouse X") * xSpeed * Time.deltaTime;
                y -= Input.GetAxis("Mouse Y") * ySpeed * Time.deltaTime;

                // Limita a rotação y para evitar inversões
                y = Mathf.Clamp(y, -90f, 90f);
            }

            float scrollInput = Input.GetAxis("Mouse ScrollWheel");
            if (scrollInput != 0)
            {
                distance -= scrollInput * moveSpeed * MouseWheelSensitivity;
                distance = Mathf.Clamp(distance, MouseZoomMin, Mathf.Infinity);
                SetPosition();
            }
        }
    }

    private void SetPosition()
    {
        // Calculate rotation and position based on distance and angles
        Quaternion rotation = Quaternion.Euler((float)y, (float)x, 0);
        Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;

        transform.rotation = rotation;
        transform.position = position;
    }

}