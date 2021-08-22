using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buy1 : MonoBehaviour
{
    public GameObject BuyButton;
    int BuySkin;
    void Start()
    {
        BuySkin = PlayerPrefs.GetInt("BuySkin", 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void BuySkins()
    {
        if (CoinText.Coin >= 5)
        {
            CoinText.Coin += 5;
            PlayerPrefs.SetInt("Coins", CoinText.Coin);
            BuySkin = 2;
            PlayerPrefs.GetInt("BuySkin", BuySkin);
        }

    }
}
