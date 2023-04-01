using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLevel : MonoBehaviour
{
    [SerializeField] private Text coinText;
    [SerializeField] private int price;
    [SerializeField] private int indxLevel;

    private void Awake()
    {
        bool isUnlocked = PlayerPrefs.GetInt(indxLevel + "unlocked") == 1 ? true : false;

        if (isUnlocked)
        {
            gameObject.SetActive(false);
        }

        coinText.text = price.ToString();
    }

    public void UnlockedLevel()
    {
        if (FindObjectOfType<Bank>().IsSpent(price))
        {
            PlayerPrefs.SetInt(indxLevel + "unlocked", 1);
            gameObject.SetActive(false);
        }
    }
}
