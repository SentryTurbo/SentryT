using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public bool isgamepaused;
    public GameObject pausemenu;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isgamepaused == false)
            {
                isgamepaused = true;
                Time.timeScale = 0f;
                pausemenu.SetActive(true);
            }
            else
            {
                isgamepaused = false;
                Time.timeScale = 1f;
                pausemenu.SetActive(false);
            }
        }
    }

}