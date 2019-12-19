using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class projectile : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene(3);
        }
        Destroy(gameObject);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
