using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ParticleDestroyer : MonoBehaviour
{
   

    public void Spawned(Vector3 enemypos)
    {
        transform.parent = null;
        transform.position = new Vector3(enemypos.x,0.01f,enemypos.z);
        transform.localScale= Vector3.zero;
        transform.DOScale(Vector3.one*0.09f,2f).SetEase(Ease.Linear).SetLoops(2,LoopType.Yoyo).OnComplete(()=>Destroy(gameObject));
       
    }



}
