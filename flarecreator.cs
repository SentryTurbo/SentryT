using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flarecreator : MonoBehaviour
{

    public GameObject flareprefab;
    public GameObject player;
    public int flarecount;
    public AudioSource ignitesound;
    public static int flarecount1;

    
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(flarecount >= 1)
            {
                ignitesound.Play();
                GameObject player = Instantiate(flareprefab, transform.position, transform.rotation);

                flarecount--;
            }


        }

        flarecount1 = flarecount;

    }
}
