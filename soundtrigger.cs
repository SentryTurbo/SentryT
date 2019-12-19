using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrigger : MonoBehaviour
{
    public AudioSource sound;
    public GameObject trigger;

    private void OnTriggerEnter(Collider other)
    {
    if  (other.gameObject.tag == "Player")
        {
            sound.Play();
            trigger.SetActive(false);
        }
    }

}
