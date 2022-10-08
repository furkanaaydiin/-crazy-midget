using DG.Tweening;
using UnityEngine;

namespace crazy.Scripts
{
   public class CoinDestroyer : MonoBehaviour
   {
    
      public GameObject coin;

      public void CoinSpawned(Vector3 enemyCoinPos)
      {
         var transform1 = transform;
         transform1.parent = null;
         transform1.position = new Vector3(enemyCoinPos.x,0.200f,enemyCoinPos.z);
         coin. transform.DOJump(enemyCoinPos,0.5f,1,1);
         coin.transform.DOScale(Vector3.one * 0.09f,1f).SetEase(Ease.Linear).SetLoops(-1,LoopType.Yoyo); 
   
      }


   }
}
