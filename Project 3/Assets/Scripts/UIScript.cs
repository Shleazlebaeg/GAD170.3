using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public CameraScript cameraScript;

    public GameObject inventoryTutorial;
    public GameObject flashlightTutorial;
    public GameObject hazardTutorial;

    public DynamiteScript dynamiteScript;
    public Inventory inventory;

    public GameObject hotBar;
    public GameObject inventoryAddText;
    public GameObject inventoryRemoveText;
    public GameObject loseScreen;
    public GameObject WinScreen;
    

    // Start is called before the first frame update
    void Start()
    {
    }

   public void InventoryAdd()
    {
            inventoryAddText.SetActive(true);
            hotBar.SetActive(true);
            Invoke("InvClear", 1.0f);
    }
    public void InventoryRemove()
    {
        inventoryRemoveText.SetActive(true);
        hotBar.SetActive(false);
        Invoke("InvClear", 1.0f);
    }

    public void GameLose()
    {
        Cursor.lockState = CursorLockMode.None;
        inventoryAddText.SetActive(false);
        inventoryRemoveText.SetActive(false);
        loseScreen.SetActive(true);
    }
    public void GameWin()
    {
        Cursor.lockState = CursorLockMode.None;
        inventoryAddText.SetActive(false);
        inventoryRemoveText.SetActive(false);
        WinScreen.SetActive(true);
    }

    public void InvClear()
    {
       inventoryAddText.SetActive(false);
       inventoryRemoveText.SetActive(false);
    }
    public void InventoryPopUp()
    {
        Cursor.lockState = CursorLockMode.None;
        cameraScript.enabled = false;
        inventoryTutorial.SetActive(true);
    }
    public void FlashlightPopUp()
    {
        Cursor.lockState = CursorLockMode.None;
        cameraScript.enabled = false;
        flashlightTutorial.SetActive(true);
    }
    public void HazardPopUp()
    {
        Cursor.lockState = CursorLockMode.None;
        cameraScript.enabled = false;
        hazardTutorial.SetActive(true);
    }

}
