using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlarePickup : MonoBehaviour
{

    public GameObject flarepickuptext;
    public GameObject flarebox;
    public GameObject Player;
    public AudioSource pickupsound;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            flarepickuptext.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            flarepickuptext.SetActive(false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown("e"))
            {
                pickupsound.Play();
                flarebox.SetActive(false);
                Player.GetComponent<flarecreator>().flarecount++;
                flarepickuptext.SetActive(false);
            }
        }
    }



}
