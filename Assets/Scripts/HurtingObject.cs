using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtingObject : MonoBehaviour
{
    public int vida;
    public HealthManager healthManager;
    private void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthManager.UpDateHealth(-vida);
        }
    }
}
