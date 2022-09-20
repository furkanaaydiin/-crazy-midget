using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy_Spawner_Rotation : MonoBehaviour
{
    public GameObject spawner;
    public float speed;
    
    void Update()
    {
        spawner.transform.DOLocalRotate( new Vector3 (0,speed* Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
    }

    
}
