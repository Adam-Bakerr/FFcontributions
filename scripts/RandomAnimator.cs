using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimator : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public GameObject Text;
    void Start()
    {
        anim = Text.GetComponent<Animator>();
        anim.SetFloat("Offset",3.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
