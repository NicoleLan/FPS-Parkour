﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;
    public UImanager uiManager;

    public bool UpDateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            //Impedir que se pueda hacer la operación
            return false;
        }
        else
        {
            playerMoney += amount;
            uiManager.UpDateMoneyUI(playerMoney.ToString());
            return true;
        }
        
    }

    private void Start()
    {
        uiManager.UpDateMoneyUI(playerMoney.ToString());

    }
}


