using DG.Tweening;
using UnityEngine;

namespace crazy.Scripts.enemy
{
    public sealed class EnemySpawnerRotation : MonoBehaviour
    {
        public GameObject spawner;
        public float speed;
        private void Update()
        {
            spawner.transform.DOLocalRotate( new Vector3 (0,speed* Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }

    
    }
}
