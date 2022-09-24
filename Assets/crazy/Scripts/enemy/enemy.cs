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

    [SerializeField] public GameObject[] splash = new GameObject[4];

    public GameObject splashRed;
    public GameObject splashYellow;
    public GameObject splashBlue;
    public GameObject splashPurple;
    
    void Start()
    {
        
        enemyanim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>(); 
        
    }
    void Update()
    {
         enemyanim.SetFloat("hız",agent.velocity.magnitude );     
         mesafe = Vector3.Distance(transform.position , hedef.position);
        
        agent.destination = hedef.position;
          if(mesafe <= 100)
         {
              agent.enabled = true;
         }
         
        
    }

    void SplashRandom()
    {

        splash[0] = splashRed;
        splash[1] = splashYellow;
        splash[2] = splashBlue;
        splash[3] = splashPurple;
    
    }

    
  
}
