using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Image))]
public class FadeOur : MonoBehaviour
{
    //To use Call StartCoroutine(Fade()); this will cause a complete fade to occur;
    // values of BlackDelay can be editied to give desired length of fade.

    public Image ImageRender;
    private float alphaValue;
    private bool fadingout;
    private bool fadingin;
    [Range(0f, 10.0f)]
    public float BlackDelay;
    private float timeValue;
    //public AudioSource scream1;
    ScreamHandler sh;


    private void Start()
    {
        //ScreamHandler sh = scream1.GetComponent<ScreamHandler>();
    }

    public void StartFade() {
        StartCoroutine(Fade());

    }
    void FixedUpdate()
    {
        if (fadingout) {
        GetComponent<Image>().enabled = true;
        alphaValue = Mathf.Lerp(0.0f, 1.0f, timeValue);
        ImageRender.color = new Color(0.0f, 0.0f, 0.0f, alphaValue);
        timeValue += Time.deltaTime/1.5f;
        if (alphaValue >= 1.0f)
        {
                //scream1.Play(0);
                fadingout = false;
                timeValue = 0.0f;
            }
        }

        if (fadingin)
        {
            alphaValue = Mathf.Lerp(1.0f, 0.0f, timeValue);
            ImageRender.color = new Color(0.0f, 0.0f, 0.0f, alphaValue);
            timeValue += Time.deltaTime / 2.5f;

            if (alphaValue == 0)
            {
                fadingin = false;
                timeValue = 0.0f;
            }
        }
    }

    IEnumerator Fade()
    {
        fadingout = true;
        int temp = PlayerPrefs.GetInt("FingersLeft");
        PlayerPrefs.SetInt("FingersLeft", temp - 1);
        // statement to check wether the fingers remaining in player prefs is zero eg game over
        yield return new WaitForSeconds(BlackDelay);
        fadingin = true;


    }

}
