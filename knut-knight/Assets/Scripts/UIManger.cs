using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManger : MonoBehaviour
{
   public GameObject myCanvas;


    // Start is called before the first frame update
    void Start()
    {
        myCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
            handlePausePressed(); 
    }
    public void quitGame()
    {
        SceneHandler.GetInstance().restartScene();
    }
    void handlePausePressed()
    {
        if (myCanvas.activeSelf == false)
        {
            pauseGame();
        }
        else
        {
            unpauseGame();
        }
           
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        myCanvas.SetActive(true);
    }

    public void unpauseGame()
    {
        Time.timeScale = 1.0f;
        myCanvas.SetActive(false);
    }
}
