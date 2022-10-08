using UnityEngine;

namespace crazy.Scripts.enemy
{
    public sealed class EnemySpawner : MonoBehaviour
    {
        public float startTime;
        public GameObject[] enemy;
        public Transform spawner,player;
        private float time;

        private void Start()
        {
            player=GameObject.FindWithTag("Player").transform;
        }

        private void Update()
        {
            if(time <= 0)
            { 
                EnemyClone();
                time = startTime;
            }
            else
            {
                time -= Time.deltaTime;
            }
        
        }

        private void  EnemyClone()
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
            GameObject newEnemy  = enemy[Random.Range(0,enemy.Length)];
            newEnemy = Instantiate(newEnemy,spawner.position,player.rotation);
            global::crazy.Scripts.enemy.Enemy createdenemy = newEnemy.GetComponent<global::crazy.Scripts.enemy.Enemy>();
            createdenemy.playerAim = player;
        }
    }
}
