using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource Asource;
    public AudioClip Scream1;
    public AudioClip Scream2;
    public AudioClip Scream3;
    public AudioClip Scream4;
    public AudioClip Scream5;
    public AudioClip Scream6;
    public AudioClip Scream7;
    public AudioClip Scream8;
    public AudioClip Scream9;
    public AudioClip Scream10;

    
    public void randomsound() {
        int random = Random.Range(1, 10);
        switch (random)
        {
            case 1:
                Asource.clip = Scream1;
                break;
            case 2:
                Asource.clip = Scream2;
                break;
            case 3:
                Asource.clip = Scream3;
                break;
            case 4:
                Asource.clip = Scream4;
                break;
            case 5:
                Asource.clip = Scream5;
                break;
            case 6:
                Asource.clip = Scream6;
                break;
            case 7:
                Asource.clip = Scream7;
                break;
            case 8:
                Asource.clip = Scream8;
                break;
            case 9:
                Asource.clip = Scream9;
                break;
            case 10:
                Asource.clip = Scream10;
                break;

        }
    
    
    }
}
