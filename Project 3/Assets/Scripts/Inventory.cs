using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public UIScript uiScript;

    public GameObject dynamite1;
    public GameObject dynamite2;
    public GameObject playerCamera;

    public Transform player;
    public Transform inventory;
    public Transform dynamiteManager;

    public Vector3 hiddenLocation = new Vector3(-100, -100, -100);
    public Vector3 playerLocation;

    public bool dynamiteInInventory = false;
    public bool dynamitePlaced = false;

    public float distanceFromDynamite;
    public float distanceXFromDynamite;
    public float distanceZFromDynamite;
    

    void Update()
    {
        playerLocation = playerCamera.transform.position;
        distanceXFromDynamite = player.transform.position.x - dynamite1.transform.position.x;
        distanceZFromDynamite = player.transform.position.z - dynamite1.transform.position.z;

        if(Input.GetKeyDown(KeyCode.E) && distanceXFromDynamite < 5 && distanceXFromDynamite > -5 && distanceZFromDynamite < 5 && distanceZFromDynamite > -5)
        {
            dynamite1.transform.parent = inventory;
            dynamite1.transform.position = hiddenLocation;
            uiScript.InventoryAdd();
            dynamiteInInventory = true;
            dynamitePlaced = false;
        }
        if (Input.GetKeyDown(KeyCode.G) && dynamiteInInventory == true)
        {
            dynamite1.transform.parent = dynamiteManager;
            dynamite1.transform.position = playerLocation + player.TransformDirection(new Vector3(0f, -3.6f, 2f));
            uiScript.InventoryRemove();
            dynamiteInInventory = false;
            dynamitePlaced = true;
        }
    }
}
