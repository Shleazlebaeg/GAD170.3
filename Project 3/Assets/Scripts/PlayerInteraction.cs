using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public Inventory inventory;
    public DynamiteScript dynamiteScript;

    public GameObject dynamite1;
    public GameObject dynamite2;
    public GameObject barrier;

    public bool pickUpTutorialCompleted = false;

    public float distanceXFromDynamite;
    public float distanceZFromDynamite;

    void Update()
    {
        distanceXFromDynamite = barrier.transform.position.x - dynamite1.transform.position.x;
        distanceZFromDynamite = barrier.transform.position.z - dynamite1.transform.position.z;

        if (Input.GetMouseButtonDown(0) && distanceXFromDynamite < 5 && distanceXFromDynamite > -5 && distanceZFromDynamite < 5 && distanceZFromDynamite > -5 && pickUpTutorialCompleted == true)
        {
            dynamite2.transform.position = dynamite1.transform.position;
            dynamite1.transform.position = inventory.hiddenLocation;
            dynamiteScript.LightDynamite();
        }
    }
}
