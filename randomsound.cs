using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomsound : MonoBehaviour
{
    public int n;
    public AudioSource sound;
    public AudioClip[] drone;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Randomsound",Random.Range(20f, 40f), Random.Range(20f, 40f) );

    }

    public void Randomsound()
    {
        n = Random.Range(0, 5);
        sound.clip = drone[n];
        sound.PlayOneShot(sound.clip);
        n = Random.Range(0, 5);

    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
