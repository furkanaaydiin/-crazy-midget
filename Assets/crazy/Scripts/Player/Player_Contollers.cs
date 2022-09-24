using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_Contollers : MonoBehaviour
{
    
     UI uI;
    float bell = 100.0f;
    float currtentBell = 100.0f;
    Image bellBar;
    public GameObject restartButton;
      


      void Start()
     {
        bellBar = GameObject.Find("Canvas/Bell").GetComponent<Image>();
    }
    
private void OnTriggerEnter(Collider col)
 {
    if(col.gameObject.CompareTag("enemy"))
         {
            currtentBell -= 10f;
            bellBar.fillAmount = currtentBell / bell;
            if(currtentBell<=0)
            {
                Time.timeScale = 0;
                restartButton.SetActive(true);
                
            }
         }
 }
 public void RestartButoon()
{
   SceneManager.LoadScene(0);
  // uI.playButton.SetActive(false);
}

}




