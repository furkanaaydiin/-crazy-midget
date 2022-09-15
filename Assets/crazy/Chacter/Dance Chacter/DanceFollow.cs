using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DanceFollow : MonoBehaviour
{

    [SerializeField] public GameObject player;
      void Update()
    {
        gameObject.transform.LookAt(player.transform);
       

    }
}
