using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer_destroy : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("enemy"))
        {
            Destroy(col.gameObject);
        }
    }
    
       
        
       
}
