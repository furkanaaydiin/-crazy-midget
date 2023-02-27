using UnityEngine;

namespace crazy.Scripts
{
    public static class Constants
    {
        public static bool ısFirstOpen = true;
    }
    public class UI : MonoBehaviour
    {
        public GameObject pauseButton;
        public GameObject playButton;
        public GameObject quitButton;
        public GameObject joystick;
        public GameObject player;

        private bool gameStop = true;
        private bool gamePlay = true;


        private void Awake()
        {
            Time.timeScale = 0;
            if(!Constants.ısFirstOpen)
            {
                playButton.SetActive(false);
                quitButton.SetActive(false);
                Time.timeScale = 1;
                joystick.SetActive(true);
            }
            else Constants.ısFirstOpen = false;
        }
        public void GamePlay_Button()
        {
            if(gamePlay)
            { 
                if(Time.timeScale == 0)
            
                    Time.timeScale = 1f;
                playButton.SetActive(false);
                quitButton.SetActive(false);
                pauseButton.SetActive(true);
                joystick.SetActive(true);
                player.SetActive(true);
            }
       
        }
        public void QuitButton()
        {
            Application.Quit();
        }


        public void GameStop_Button()
        {
            gameStop = !gameStop;
            if(gameStop)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    

    
    }
}