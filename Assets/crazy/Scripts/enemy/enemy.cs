
using UnityEngine;
using UnityEngine.AI;

namespace crazy.Scripts.enemy
{
    public sealed class Enemy : MonoBehaviour
    {
        private Animator enemyAnim;
        [SerializeField] public Transform playerAim;
        private NavMeshAgent  agent;
        [SerializeField] public float distance;
        private static readonly int Hız = Animator.StringToHash("hız");

        private void Start()
        {
        
            enemyAnim = GetComponent<Animator>();
            agent = GetComponent<NavMeshAgent>(); 
        
        }

        private void Update()
        {
            enemyAnim.SetFloat(Hız,agent.velocity.magnitude );
            var position = playerAim.position;
            distance = Vector3.Distance(transform.position , position);
        
            agent.destination = position;
            if(distance <= 100)
            {
                agent.enabled = true;
            }
         
        
        }
      
        
    }
    
    
}

