using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy : MonoBehaviour
{
    Animator enemyanim;
    [SerializeField] public Transform hedef;
    NavMeshAgent  agent;
    [SerializeField] public float mesafe;
    Vector3 newPosition;
    [SerializeField] public GameObject player;
    [SerializeField] GameObject enemy1;
    [SerializeField] GameObject enemy2;
    [SerializeField] GameObject enemy3;
    [SerializeField] GameObject enemy4;



    

    void Start()
    {
        
        enemyanim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>(); 
        
    }

   
    void Update()
    {
         enemyanim.SetFloat("hız",agent.velocity.magnitude );     
         mesafe = Vector3.Distance(transform.position , hedef.position);
         
         player.transform.position = newPosition;
        
        agent.destination = hedef.position;
          if(mesafe <= 100)
         {
              agent.enabled = true;
         }
        
    }

    
  
}
