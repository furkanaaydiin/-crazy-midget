using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player_swat : MonoBehaviour
{
    
    public GameObject boll;
    public float speed;
    public bool direction;
     private void Update()
    {
        if(direction == false)
        {
            boll.transform.DORotate( new Vector3 (0,speed * Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }
        else
        {
             boll.transform.DORotate( new Vector3 (0,-1*speed * Time.deltaTime,0),-1,RotateMode.WorldAxisAdd);
        }
    }

    
    
    
}
