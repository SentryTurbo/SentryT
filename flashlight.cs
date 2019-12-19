using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{

    public AudioSource audiosrc;
    public Light flashlightobject;
    public bool isflashlighton;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            if (isflashlighton == true)
            {
                flashlightobject.enabled = false;
                isflashlighton = false;
                audiosrc.Play();
            }

            else
            {
                flashlightobject.enabled = true;
                isflashlighton = true;
                audiosrc.Play();
            }


        }

    }
}
