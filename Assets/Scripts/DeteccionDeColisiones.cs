using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto");
        Destroy(gameObject); //En minúscula refiere al objeto que tiene el Script.
        //Destroy(collision); //Desaparece el objeto al que colisiona.
    }
}