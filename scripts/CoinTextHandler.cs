using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CoinTextHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TextPro;
    public string currentcoins;
    void Start()
    {
        UpdateCoins();
    }

    // Update is called once per frame
    public void UpdateCoins()
    {
        currentcoins = "";
       
        currentcoins = currentcoins + PlayerPrefs.GetInt("Coins").ToString();
        TextPro.SetText(currentcoins);
    }
}
