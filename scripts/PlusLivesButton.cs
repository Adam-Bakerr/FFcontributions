using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusLivesButton : MonoBehaviour
{

    public int livescost;
    public GameObject liveupdate;
    public GameObject coinsupdate;
    LivesTextHandler livestext;
    CoinTextHandler cointext;
    // Start is called before the first frame update
    void Start()
    {
        livestext = liveupdate.GetComponent<LivesTextHandler>();
        cointext = coinsupdate.GetComponent<CoinTextHandler>();
    }

    // Update is called once per frame
    public void PurchaseLives()
    {
        int lives = PlayerPrefs.GetInt("FingersLeft");
        int currentcoins = PlayerPrefs.GetInt("Coins");
        if (lives < 5 && currentcoins >= livescost)
        {
            PlayerPrefs.SetInt("Coins", currentcoins - livescost);
            PlayerPrefs.SetInt("FingersLeft", lives + 1);
            livestext.UpdateLives();
            cointext.UpdateCoins();

        }
        else {
            Debug.Log("test");
                }
        
        
        }

    }

