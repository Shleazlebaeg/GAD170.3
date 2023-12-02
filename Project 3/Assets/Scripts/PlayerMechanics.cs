using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMechanics : MonoBehaviour
{
    public GameObject flashlight;
    public bool flashlightOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && flashlightOn) 
        {
            flashlightOn = false;
        }
        else if (Input.GetKeyDown(KeyCode.F) && flashlightOn == false)
        {            
            flashlightOn = true;
        }

        if (flashlightOn == true)
        {
            flashlight.SetActive(true);
        }
        else if (flashlightOn == false)
        {
            flashlight.SetActive(false);
        }

    }
}
