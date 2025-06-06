using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UImanager : MonoBehaviour
{
    public TextMeshPro txtMoney;
    public DineroManager dineroManager;

    private void Start()
    {
        dineroManager = FindObjectOfType<DineroManager>();

    } 

    public void UpDateMoneyUI(string moneyAmount)
    {
        txtMoney.text = moneyAmount;
    }
}
