using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Events : MonoBehaviour
{
    public GameObject menuscreen;
    public GameObject creditsscreen;
    public GameObject howtoplayscreen;


    public void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }



    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void credits()
    {
        menuscreen.SetActive(false);
        creditsscreen.SetActive(true);
        howtoplayscreen.SetActive(false);
    }

    public void howtoplay()
    {
        howtoplayscreen.SetActive(true);
        creditsscreen.SetActive(false);
        menuscreen.SetActive(false);
    }
    public void menuscreenon()
    {
        howtoplayscreen.SetActive(false);
        creditsscreen.SetActive(false);
        menuscreen.SetActive(true);
    }

}
