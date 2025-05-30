using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{
    public int precio;
    public DineroManager dineroManager;
    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Restar el precio al dinero del player
            dineroManager.UpDateMoney(-precio);
            Destroy(gameObject);
        }
    }
}
