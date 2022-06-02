using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public Transform transform;
    public Canvas canvas;
    public float shakeduration = 0f;
    [Range(0f, 10.0f)]
    public float shakestrength = .7f;
    private float damping = 1f;
    Vector3 intial;
    // Start is called before the first frame update


    // Update is called once per frame
    void OnEnable()
    {
        intial = transform.localPosition;
    }

    private void FixedUpdate()
    {
        if (shakeduration > 0)
        {
            transform.localPosition = intial + Random.insideUnitSphere * shakestrength;

            shakeduration -= Time.deltaTime * damping;
        }
        else
        {
            shakeduration = 0f;
            transform.localPosition = intial;
        }
    }

    public void TriggerShake()
    {
        shakeduration = .75f;
    }

}