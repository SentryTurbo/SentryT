using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrack : MonoBehaviour
{

    public AudioSource music;
    
    // Start is called before the first frame update
    void Start()
    {

        music.PlayDelayed(5f);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
