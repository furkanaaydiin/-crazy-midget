using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinDestroyer : MonoBehaviour
{
    
public GameObject coin;
// Transform panel;
// Sequence goldAnimation;


// private void Start()
// {
//    GoldAnimation();
// }

public void CoinSpawned(Vector3 enemyConinPos)
{
    
   transform.parent = null;
   transform.position = new Vector3(enemyConinPos.x,0.200f,enemyConinPos.z);
   transform.localScale = Vector3.zero;
   coin. transform.DOJump(enemyConinPos,0.5f,1,1);
   coin.transform.DOScale(Vector3.one * 0.09f,1f).SetEase(Ease.Linear).SetLoops(1,LoopType.Yoyo); 
   
}

// public void GoldAnimation()
// {
//    panel = GameObject.FindGameObjectWithTag("GoldPanel").transform;
//    goldAnimation = DOTween.Sequence();
//    goldAnimation.Append(transform.DOMove(panel.position,2)).SetEase(Ease.OutSine).OnComplete(() => Destroy(gameObject));
// }

}
