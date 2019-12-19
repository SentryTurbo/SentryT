using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class flarescript : MonoBehaviour
{
    public GameObject flare;
    

    private void Start()
    {
        Invoke("destroy", 10f);
    }

     void destroy()
    {
        flare.SetActive(false);
    }




}
