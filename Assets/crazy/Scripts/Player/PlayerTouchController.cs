using UnityEngine;


namespace crazy.Scripts.Player
{
    public class PlayerTouchController : MonoBehaviour
    {
        [SerializeField] private Animator animator;
        [SerializeField] private new Rigidbody rigidbody;
        [SerializeField] private Joystick joystick;
        [SerializeField] private float movementSpeed;
        [SerializeField] private float rotationSpeed = 500;
        private static readonly int IsMoving = Animator.StringToHash("IsMoving");
        private void Awake()
        {
            rigidbody = GetComponent<Rigidbody>();
        }
        protected virtual void FixedUpdate()
        {
            if(joystick.Direction.magnitude > 0.1f){
                animator.SetBool(IsMoving,true);
                var direction = new Vector3(joystick.Horizontal,0,joystick.Vertical);
                var lookRotation = Quaternion.LookRotation(-direction);
                var playerTransform = transform;
                playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation,lookRotation,Time.deltaTime*rotationSpeed);
                rigidbody.MovePosition(playerTransform.position + playerTransform.forward * (movementSpeed * Time.fixedDeltaTime));
                if(rigidbody.velocity.magnitude > 5)
                {
                    rigidbody.velocity = rigidbody.velocity.normalized *5;
                
                }
            }
            else animator.SetBool(IsMoving,false); 
        
        }
    }
}
