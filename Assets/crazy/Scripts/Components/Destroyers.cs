using crazy.Scripts.enemy;
using UnityEngine;

namespace crazy.Scripts.Player.Destroyer
{
    public class Destroyers : MonoBehaviour
    {
        [SerializeField] private ParticleDestroyer splash;
        [SerializeField]private CoinSpawner coinSplash;

        private void OnTriggerEnter(Collider col)
        {
            if(col.gameObject.CompareTag("enemy"))
            { 
                Destroy(col.gameObject);
                //Kan 
                var splashGo = Instantiate(splash);
                var position = col.transform.position;
                splashGo.Spawned(position);
                //Coin 
                var newCoin = Instantiate(coinSplash);
                newCoin.CoinSpawned(position);
            }
        }
    
       
        
       
    }
}
