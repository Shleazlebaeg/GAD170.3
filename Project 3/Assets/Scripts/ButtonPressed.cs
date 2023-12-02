using System.Threading;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public UIScript uiScript;
    public PlayerMovement playerMovement;
    public PlayerMechanics playerMechanics;
    public PlayerHealth playerHealth;
    public DynamiteScript dynamiteScript;
    public HazardScript hazardScript;
    public CameraScript cameraScript;

    public Transform player;

    public GameObject dynamite1;
    public GameObject dynamite2;
    public GameObject barrier;
    public GameObject flashlight;

    public Vector3 SpawnPosition = new Vector3(0, 2, 0);

    // public function to be called on button press
    public void ButtonPressed()
    {
        player.transform.position = SpawnPosition;
        dynamiteScript.PlaceDynamite();
        barrier.transform.position = new Vector3(0.1199848f, 0.809998f, 98.74001f);
        playerHealth.playerMaxHealth = 100;
        playerHealth.playerHealth = 100;
        uiScript.loseScreen.SetActive(false);
        uiScript.WinScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        playerMechanics.flashlightOn = false;
    }

    
}