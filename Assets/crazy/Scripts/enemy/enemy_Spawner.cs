using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Spawner : MonoBehaviour
{
    public float startTime;
    public GameObject[] enemy;
    public Transform spawner,player;
    float time;
    

private void Start()
{
    player=GameObject.FindWithTag("Player").transform;
}
void Update()
{
    if(time <= 0)
    {
         enemyspawner();
        time = startTime;
    }
    else
    {
        time -= Time.deltaTime;
    }
        
 }

    private void enemyspawner()
    {
        
         transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z);
         GameObject newenemy  = enemy[Random.Range(0,enemy.Length)];
         newenemy = Instantiate(newenemy,spawner.position,player.rotation);
         enemy createdenemy = newenemy.GetComponent<enemy>();
         createdenemy.hedef = player;
         newenemy.transform.SetParent(transform);

         
    }
}
