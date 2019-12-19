using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;
using System.Threading.Tasks;
using UnityEngine.Video;


public class aiattack : MonoBehaviour
{

    public Camera player;
    public NavMeshAgent skeletor;
    public Animation monsteranimator;
    public SphereCollider see;
    public GameObject playerobject;
    public CharacterController controlleras;
    public AudioSource jumpscare;
    public VideoPlayer videoclip;
    public AudioSource scarymusic;



    // Start is called before the first frame update
    void Start()
    {
        Task delay = Task.Delay(1000);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            attackplayer();
        }
    }


    // Update is called once per frame
    void Update()
    {
        

        
    }

    void attackplayer()
    {
        playerobject.transform.Rotate(skeletor.transform.position);
        //skeletor.transform.LookAt(playerobject.transform.position);
        skeletor.enabled = false;
        controlleras.enabled = false;
        see.enabled = false;
        monsteranimator.Play("Idle1");
        monsteranimator.Play("HitKill");
        Debug.Log("you're fucking dead");
        scarymusic.Stop();
        videoclip.Play();
        jumpscare.Play();

        Invoke("death", 1f);
        
        


    }

    public void death()
    {
        SceneManager.LoadScene(2);
    }


}
