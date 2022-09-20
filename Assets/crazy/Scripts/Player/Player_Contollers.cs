using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player_Contollers : MonoBehaviour
{

 [SerializeField] destroyer_destroy destroyer_Destroy;
    private void Update()
    {
        destroyer_Destroy = GetComponent<destroyer_destroy>();
    }
    
    
    
}

