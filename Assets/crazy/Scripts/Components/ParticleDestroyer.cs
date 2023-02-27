using DG.Tweening;
using UnityEngine;

namespace crazy.Scripts.enemy
{
    public class ParticleDestroyer : MonoBehaviour
    {
        public void Spawned(Vector3 enemyPos)
        {
            var transform1 = transform;
            transform1.parent = null;
            transform1.position = new Vector3(enemyPos.x,0.01f,enemyPos.z);
            transform1.localScale= Vector3.zero;
            transform.DOScale(Vector3.one*0.09f,2f).SetEase(Ease.Linear).SetLoops(2,LoopType.Yoyo).OnComplete(()=>Destroy(gameObject));
       
        }



    }
}
