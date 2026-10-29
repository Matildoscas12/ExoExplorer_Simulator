using UnityEngine;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Planet switch.
/// </summary>
public class PlanetSwitch : MonoBehaviour {

    public string planetName;
    public float baseDistance = 2.5f;
    public float baseScrollSpeed = 0.1f;

    private RotationAroundPlanet rotationAroundPlanetScript;
    private GameObject sunLight;

    void Start()
    {
        rotationAroundPlanetScript = Camera.main.GetComponent<RotationAroundPlanet>();
    }

    public void AssignPlanetCameraCoordinates(string selectedPlanetName)
    {
        planetName = selectedPlanetName;

        GameObject planet = GameObject.Find(selectedPlanetName);

        if (planet != null && rotationAroundPlanetScript != null)
        {
            rotationAroundPlanetScript.target = planet.transform;

            float distance = baseDistance * planet.transform.localScale.x * planet.transform.parent.localScale.x;
            rotationAroundPlanetScript.distance = distance;

            float sensitivity = baseScrollSpeed * planet.transform.localScale.x;
            rotationAroundPlanetScript.MouseWheelSensitivity = sensitivity;

            float minZoom = planet.transform.localScale.x * 2f;
            rotationAroundPlanetScript.MouseZoomMin = minZoom;

            if (sunLight != null)
            {
                sunLight.SetActive(selectedPlanetName != "Sun");
            }
        }
    }

}
