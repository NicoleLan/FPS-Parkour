using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float playerHealth;
    public UImanager uiManager;

    public bool UpDateHealth(float amount)
    {

        if (playerHealth + amount < 0)
        {
            //Impedir que se pueda hacer la operación
            return false;
        }
        else
        {
            playerHealth += amount;
            uiManager.UpDateHealthUI(playerHealth.ToString());
            return true;
        }

    }

    private void Start()
    {
        uiManager.UpDateHealthUI(playerHealth.ToString());

    }
}
