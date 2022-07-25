using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginTrigger : MonoBehaviour
{
   [SerializeField] private GameObject begin;
   private void OnTriggerEnter(Collider other)
   {
    if(other.gameObject.CompareTag("BeginTrigger"))
    {
        begin.SetActive(false);
    }
   }
}
