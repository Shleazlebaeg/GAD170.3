using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class DynamiteScript : MonoBehaviour
{
    public Inventory inventory;
    public UIScript uiScript;    

    public GameObject dynamite;
    public GameObject dynamite2;
    public GameObject barrier;

    public ParticleSystem explosion;

    void Start()
    {
        explosion.Stop();
        PlaceDynamite();
    }

    public void PlaceDynamite()
    {
        dynamite.transform.position = new Vector3(Random.Range(-100, 100), 0.1f, Random.Range(-100, 100));
    }
    public void LightDynamite()
    {
        dynamite2.transform.position = new Vector3(0f, .1f, 97f);
        Invoke("Explosion", 5f);
    }

    void Explosion()
    {
        explosion.Play();
        Invoke("StopExplosion", 1f);
        barrier.transform.position = new Vector3(500, 500, 500);
        dynamite2.transform.position = new Vector3(700, 700, 700);
    }
    void StopExplosion()
    {
        explosion.Stop();
    }
}
