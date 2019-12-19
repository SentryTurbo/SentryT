using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileshooter : MonoBehaviour
{
    public GameObject ambmusic;
    public GameObject chasemusic;
    public GameObject chaseendmusic;
    public GameObject barrel;
    public GameObject prefab;
    public GameObject monstersex;
    public GameObject tutorial;
    public AudioSource gunsound;


    // Start is called before the first frame update
    void Start()
    {
        ambmusic.SetActive(false);
        chasemusic.SetActive(false);
        chaseendmusic.SetActive(false);
        monstersex.SetActive(true);
        tutorial.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject projectile = Instantiate(prefab) as GameObject;
            projectile.transform.position = transform.position + barrel.transform.forward * 1;
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            rb.velocity = barrel.transform.forward * 300f;
            gunsound.Play();
        }
    }
}
