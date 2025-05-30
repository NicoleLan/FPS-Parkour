using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DineroManager : MonoBehaviour
{
    public float playerMoney;


    public void UpDateMoney(float amount)
    {

        if (playerMoney + amount < 0)
        {
            //Impedir que se pueda hacer la operación
        }
        else
        {
            playerMoney += amount;
        }
        
    }
    
}
