using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHazardTrigger : MonoBehaviour
{
    public UIScript uiScript;
    public TutorialInventoryTrigger inventoryTrigger;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && inventoryTrigger.completed3 == false)
        {
            uiScript.HazardPopUp();
            inventoryTrigger.completed3 = true;
        }

    }
}
