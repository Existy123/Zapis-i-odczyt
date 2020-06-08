using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{    
     public Transform player;
     public Vector3 offset;
     [Range(0.01f, 2.0f)] public float FollowSpeed = 2.0f;

     void Start()
     {
         StartCoroutine(WaitForPlayer());
     }

     
     void Update()
     {
         if (player != null) 
         {
             transform.position = Vector3.Lerp(transform.position, player.position + offset, Time.fixedDeltaTime * FollowSpeed);
         }
     }

     IEnumerator WaitForPlayer()
     {
         while (player == null)
         {
             yield return null; 
             var obj = GameObject.FindGameObjectWithTag("Player");
             if (obj!= null)
             {
                 player = obj.transform;
             }
         }
     }
}
