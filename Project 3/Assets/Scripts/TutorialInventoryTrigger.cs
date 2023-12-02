using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialInventoryTrigger : MonoBehaviour
{
    public UIScript uiScript;

    public bool completed1 = false;
    public bool completed2 = false;
    public bool completed3 = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && completed1 == false)
        {
            uiScript.InventoryPopUp();
            completed1 = true;
        }
        
    }
}
