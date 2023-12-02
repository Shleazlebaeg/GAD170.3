using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialFlashlightTrigger : MonoBehaviour
{
    public UIScript uiScript;
    public TutorialInventoryTrigger inventoryTrigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && inventoryTrigger.completed2 == false)
        {
            uiScript.FlashlightPopUp();
            inventoryTrigger.completed2 = true;
        }
        
    }
}