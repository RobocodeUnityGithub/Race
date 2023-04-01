using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bank : MonoBehaviour
{
    [SerializeField] private Text coinText;
    private int coins;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", coins);
        UpdateUI();
    }

    public bool IsSpent(int subtractionCoin)
    {
        int spentCoin = coins -  subtractionCoin;

        if (spentCoin<0)
        {
            return false;
        }

        coins = spentCoin;
        UpdateUI();
        PlayerPrefs.SetInt("Coins", coins);
        
        return true;
    }

    private void UpdateUI()
    {
        coinText.text = coins.ToString();
    }
}
