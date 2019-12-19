using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;
using UnityEngine.AI;

public class lever : MonoBehaviour
{

    public GameObject text;
    public GameObject lever1;
    public Animation leveranim;
    public bool isleveron;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public AudioSource leversound;
    public static int levers;
    public GameObject blocker;
    public NavMeshAgent skellington;

    // Start is called before the first frame update
    void Start()
    {
        blocker.SetActive(false);
        levers = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
      

    }
    
    void OnTriggerStay(Collider player)

    {
        if (player.gameObject.tag == "Player")
        {

            if (isleveron == false)
            {
                text.SetActive(true);
            }


            if (Input.GetKeyDown("e"))
            {
                if(isleveron == false)
                {
                    leveranim.Play();
                    light1.SetActive(true);
                    light2.SetActive(true);
                    light3.SetActive(true);
                    leversound.Play();
                    levers++;
                    skellington.speed ++ ;
                    blocker.SetActive(true);
                    isleveron = true;
                }
            }

        }
    }

    private void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            text.SetActive(false);
        }
    }


}
