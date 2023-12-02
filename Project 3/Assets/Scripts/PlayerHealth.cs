using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public UIScript uiScript;

    public Slider slider;
    public float playerHealth = 100;
    public float playerMaxHealth = 100;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            playerHealth -= 20;
        }
        slider.value = playerHealth;
        
        if (playerHealth <= 0)
        {
            uiScript.GameLose();
        }
    }
    public void SetMaxHealth()
    {
        slider.maxValue = playerMaxHealth;
        slider.value = playerHealth;
    }
    public void SetHealth(int health)
    {
        slider.value = playerHealth;
    }
}
