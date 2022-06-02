using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class LivesTextHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TextPro;
    public string currentlives;
    void Start()
    {
        UpdateLives();
    }

    // Update is called once per frame
    public void UpdateLives()
    {
        TextPro.SetText(PlayerPrefs.GetInt("FingersLeft").ToString()+ "\nFingers Remaining");
    }
}
