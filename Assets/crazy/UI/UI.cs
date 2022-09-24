using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{


public GameObject pouseButton;
public GameObject playButton;
//public GameObject quitButton;
public GameObject joistick;

bool gamestop = true;
 bool gameplay = true;


private void Awake()
{
    Time.timeScale = 0;
}

 public void GamePlay_Button()
    {
       
       if(gameplay == true)
       {
        if(Time.timeScale == 0)
        Time.timeScale = 1f;
        playButton.SetActive(false);
        //quitButton.SetActive(false);
        pouseButton.SetActive(true);
        joistick.SetActive(true);
       }
       
    }
//  public void QuitButton()
//  {
//      Application.Quit();
//  }


   public void GameStop_Button()
   {
        gamestop = !gamestop;
        if(gamestop == true)
        {
             Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    

    
}
