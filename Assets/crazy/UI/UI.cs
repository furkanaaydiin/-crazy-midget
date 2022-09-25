using UnityEngine;
using DG.Tweening;

public static class Constants
{
    public static bool IsFirstOpen = true;
}
public class UI : MonoBehaviour
{

public GameObject pouseButton;
public GameObject  playButton;
public GameObject quitButton;
public GameObject joistick;


bool gamestop = true;
 bool gameplay = true;


private void Awake()
{
    
    Time.timeScale = 0;
    if(!Constants.IsFirstOpen)
    {
        playButton.SetActive(false);
        quitButton.SetActive(false);
        Time.timeScale = 1;
        joistick.SetActive(true);
    }
    else Constants.IsFirstOpen = false;
}


 public void GamePlay_Button()
    {
       
       if(gameplay)
       {
        if(Time.timeScale == 0)
        Time.timeScale = 1f;
        playButton.SetActive(false);
        quitButton.SetActive(false);
        pouseButton.SetActive(true);
        joistick.SetActive(true);
       }
       
    }
 public void QuitButton()
 {
      Application.Quit();
 }


   public void GameStop_Button()
   {
        gamestop = !gamestop;
        if(gamestop)
        {
             Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    

    
}
