using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class FingersRemaining : MonoBehaviour
{
    public int fingersleft;
    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Image renderer;

    public bool fingertoremove = true;

    private const string key = "FingersLeft"; //Added by Tom (S212046).
    private const int default_fingers_left = 5; //Added by Tom (S212046). 

    //Added by Tom (S212046).
    void Awake()
    {
        fingersleft = PlayerPrefs.GetInt(key, default_fingers_left);
        renderer = gameObject.GetComponent<Image>();
        UpdateFingers();
    }
    public void FakeHand()
    {
        fingertoremove = false;
    }

    public void ResetFingers() { fingersleft = default_fingers_left; UpdateFingers(); }
    public void RemoveFinger()
    {
        if (fingertoremove == true)
        {
            fingersleft = fingersleft <= 0 ? default_fingers_left : fingersleft - 1;
            PlayerPrefs.SetInt(key, fingersleft);
            UpdateFingers();
        }
        else if (fingertoremove == false) {
            UpdateFingers();
            fingertoremove = true;
        
        }
        
    }
    // !Added by Tom (S212046).

    // Update is called once per frame
    public void UpdateFingers()
    {
        switch (fingersleft)
        {
            case 0:
                renderer.sprite = zero;
                break;
            case 1:
                renderer.sprite = one;
                break;
            case 2:
                renderer.sprite = two;
                break;
            case 3:
                renderer.sprite = three;
                break;
            case 4:
                renderer.sprite = four;
                break;
            case 5:
                renderer.sprite = five;
                break;
            default:
                break;
        }
    }
}

/* Feedback : Tom Jacobs (S212046).
 *
 * What went well?
 * The script is not only fully functional and extremely readable, which is very 
 * important when sharing work with multiple programmers and designers. I also like
 * the fact that the switch case system accounts for 'out of range' values rather than
 * throwing an error.
 * 
 * How could the script be improved?
 * If you wanted to write a more efficent and maintainable program you could instead 
 * use an array (or list) to store each frame of the hand's animation. Then instead of
 * using a 'switch-case' you could simply use an unsigned integer to keep reference to
 * the currently active frame (image) in the array of frames.
 * 
 * That being said, this system has the benefit that it's always very clear
 * what image is intended for being stored in each variable. 
 * 
 * Overall, great effort, keep up the good work! :)
 **/