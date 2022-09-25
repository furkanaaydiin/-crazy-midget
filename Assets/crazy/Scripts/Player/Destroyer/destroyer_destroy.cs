using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_destroy : MonoBehaviour
{
   [SerializeField] public ParticleDestroyer splash;
    [SerializeField]public CoinDestroyer coinSplesh;

    
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("enemy"))
        {
            Destroy(col.gameObject);
            
            //Kan Efekti
            var splashgo = Instantiate(splash);
            splashgo.Spawned(col.transform.position);
            //Coin SPAWN
            var newCoin = Instantiate(coinSplesh);
            newCoin.CoinSpawned(col.transform.position);
        }
    }
    
       
        
       
}
