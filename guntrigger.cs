using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guntrigger : MonoBehaviour
{

    public GameObject fakegun;
    public GameObject guntext;
    public GameObject gun;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            guntext.SetActive(true);


        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                fakegun.SetActive(false);
                gun.SetActive(true);
                guntext.SetActive(false);
            }


        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            guntext.SetActive(false);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
