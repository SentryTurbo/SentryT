using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class counter : MonoBehaviour
{
    public string nextlevel;
    public GameObject UIobj;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        UIobj = GameObject.Find("levercount");
    }

    // Update is called once per frame
    void Update()
    {
        UIobj.GetComponent<Text>().text = lever.levers.ToString();
        if(lever.levers == 4)
        {
            SceneManager.LoadScene(3);
        }

    }
}
