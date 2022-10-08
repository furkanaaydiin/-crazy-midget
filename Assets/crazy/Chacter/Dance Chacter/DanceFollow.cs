using UnityEngine;

namespace crazy.Chacter.Dance_Chacter
{
    public class DanceFollow : MonoBehaviour
    {

        [SerializeField] public GameObject player;
        void Update()
        {
            gameObject.transform.LookAt(player.transform);
       

        }
    }
}
