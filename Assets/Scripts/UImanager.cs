using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public DineroManager dineroManager;
    public TextMeshProUGUI txtHealth;
    public HealthManager healthManager;


    private void Start()
    {
      


    }

    public void UpDateMoneyUI(string moneyAmount)
    {
        txtMoney.text = "Dinero: $" + moneyAmount;
    }

    public void UpDateHealthUI(string healthAmount)
    {
        txtHealth.text = "Health = " + healthAmount;
    }
}

