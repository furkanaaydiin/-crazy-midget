using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDestroy : MonoBehaviour
{
     [SerializeField] public GameObject deathSpleshPrefab;

     [SerializeField] GameObject[] enemy;
      

    
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("enemy"))
        {
            GameObject splesh = Instantiate(deathSpleshPrefab , transform.position,transform.rotation);
            GameObject.FindWithTag("enemy");
                Destroy(gameObject);
            
           
        }
    }
      void DeadSplesh()
    {
        
    //    switch (enemy1,enemy2,enemy3,enemy4)
    //    {
    //     case 0: 
    //     default:
    //    }
    }
}
