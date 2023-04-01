using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private int coins;
    [SerializeField] private Text coinText;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", coins);
        UpdateUI();
    }

    private void UpdateUI()
    {
        coinText.text = coins.ToString();
        PlayerPrefs.SetInt("Coins", coins);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Coin"))
        {
            coins += other.GetComponent<CoinSetting>().GetPrice();
            other.GetComponent<CoinSetting>().PickUp();
            UpdateUI();
        }

    }
}
