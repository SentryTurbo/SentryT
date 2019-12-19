using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;


public class ai : MonoBehaviour
{

    public Camera player;
    public NavMeshAgent monster;
    public GameObject monsterobject;
    public Animation monsteranimator;
    public AudioSource footstepsounds;
    public GameObject[] waypoints;
    public int waypointind = 0;
    public AudioSource scarymusic;
    public AudioSource tail;
    public AudioSource screech;

    // Start is called before the first frame update
    void Start()
    {
        patrol();
    }

    // Update is called once per frame
    void Update()
    {

        if (waypointind > waypoints.Length)
        {
            waypointind = 0;

        }

        if(waypointind == 9)
        {
            waypointind = 10;
        }

        if (waypointind == 13)
        {
            waypointind = 14;
        }

        if (waypointind == 20)
        {
            waypointind = 21;
        }


        if (waypointind == 40)
        {
            waypointind = 0;
        }

        if (monster.hasPath)
        {
            monsteranimator.Play("Run1");
            footstepsounds.enabled = true;
        }
        else
        {

            monsteranimator.PlayQueued("Idle1");
            footstepsounds.enabled = false;


        }
        patrol();

    }

    void patrol()
    {
        if(Vector3.Distance (this.transform.position, waypoints[waypointind].transform.position) >= 2)
        {
            monster.SetDestination(waypoints[waypointind].transform.position);
            if (waypointind > waypoints.Length)
            {
                waypointind = 0;

            }
        }
        else if(Vector3.Distance(this.transform.position, waypoints[waypointind].transform.position) <= 2)
        {
            waypointind += 1;
            if (waypointind > waypoints.Length)
            {
                waypointind = 1;
                
            }
        }
        else
        {
            monster.Move(Vector3.zero);
            waypointind = 1;
        }
    }

    

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag =="Player")
        {
            scarymusic.Stop();
            tail.Play();
        }



    }

    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.gameObject.tag =="Player")
        {
            monster.SetDestination(player.transform.position);
            scarymusic.Play();
            screech.Play();

        }
    }

    
    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            monster.SetDestination(player.transform.position);

        }
    }


    void attackplayer()
    {

    }

    private void FixedUpdate()
    {
        if (monster.isStopped)
        {

            
            waypointind = 0;

            
        }

        if (waypointind > waypoints.Length)
        {
            waypointind = 0;

        }


    }

}
