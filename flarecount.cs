using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flarecount : MonoBehaviour
{
    public string nextlevel;
    public GameObject UIobj;



    // Start is called before the first frame update
    void Start()
    {
        UIobj = GameObject.Find("FlareCount");
    }

    // Update is called once per frame
    void Update()
    {
        UIobj.GetComponent<Text>().text = flarecreator.flarecount1.ToString();


    }




}
