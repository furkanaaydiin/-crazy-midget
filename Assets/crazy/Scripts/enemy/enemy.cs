
using UnityEngine;
using UnityEngine.AI;

namespace crazy.Scripts.enemy
{
    public sealed class Enemy : MonoBehaviour
    {
        [SerializeField] public Transform playerAim;
        [SerializeField] private float distance;
        private static readonly int EnemySpeed = Animator.StringToHash("EnemySpeed");
        private NavMeshAgent  agent;
        private Animator enemyAnim;
        private void Start()
        {
            enemyAnim = GetComponent<Animator>();
            agent = GetComponent<NavMeshAgent>();
        }
        private void Update()
        {
            enemyAnim.SetFloat(EnemySpeed,agent.velocity.magnitude );
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

