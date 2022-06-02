using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class backgroundManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Normal;
    public GameObject Dark;
    public float LowerWait;
    public float UpperWait;
    public float LightDelayupper;
    public float LightDelaylower;
    //false = normal true = dark
    private bool currentstate = false;
    private bool isBlinking = false;
    private float HowLongToBlinkFor = 1.5f;
    float time;
    float timedelay;

    private void FixedUpdate()
    {
        if (isBlinking == false) {
            isBlinking = true;
        StartCoroutine(blink());
        }
        
    }
    float getRandomTime() {
        time = Random.Range(LowerWait/100, UpperWait/100);
        timedelay = Random.Range(LightDelaylower/100, LightDelayupper/100);
        return time;
    }
    IEnumerator blink() {
        getRandomTime();
        yield return new WaitForSeconds(time);
        Normal.SetActive(!Normal.activeInHierarchy);
        Dark.SetActive(!Dark.activeInHierarchy);
        yield return new WaitForSeconds(timedelay);
        Normal.SetActive(!Normal.activeInHierarchy);
        Dark.SetActive(!Dark.activeInHierarchy);
        isBlinking = false;

    }
}
