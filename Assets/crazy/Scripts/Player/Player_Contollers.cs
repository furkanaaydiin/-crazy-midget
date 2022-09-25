using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class Player_Contollers : MonoBehaviour
{

    UI uI;
    float bell = 100.0f;
    float currtentBell = 100.0f;
    Image bellBar;
    [SerializeField] public GameObject restartButton;
    [SerializeField] public  GameObject goldPrefab;
    [SerializeField] public GameObject panel;



 void Start()
   {
        bellBar = GameObject.Find("Canvas/Bell").GetComponent<Image>();
   }

private void OnTriggerEnter(Collider col)
 {
    if(col.gameObject.CompareTag("enemy"))
         {
            currtentBell -= 0.03f;
            bellBar.fillAmount = currtentBell / bell;
            if(currtentBell<=0)
            {
                Time.timeScale = 0;
                restartButton.SetActive(true);

            }

         }
   // if(col.gameObject.CompareTag("coin"))
   // {
   //    Destroy(col.gameObject);
   //    Instantiate(goldPrefab,Camera.main.WorldToScreenPoint(transform.position),panel.transform.rotation,panel.transform);
      
   // }
 }
 public void RestartButoon()
{
   SceneManager.LoadScene(0);

}

}




