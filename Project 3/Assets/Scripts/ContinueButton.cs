using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MonoBehaviour
{
    public CameraScript cameraScript;
    public UIScript uiScript;
    public PlayerInteraction playerInteraction;

    public GameObject inventoryTutorial;
    public GameObject flashlightTutorial;
    public GameObject hazardTutorial;

    public void ButtonPressed()
    {
        inventoryTutorial.SetActive(false);
        flashlightTutorial.SetActive(false);
        hazardTutorial.SetActive(false);
        cameraScript.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        playerInteraction.pickUpTutorialCompleted = true;
    }
}
