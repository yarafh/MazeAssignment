using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayingWithBools : MonoBehaviour
{
    [SerializeField] private bool activated = false;
    [SerializeField] private Transform block;
    private void FixedUpdate()
    {
        if(activated == true)
            block.Translate(0,1*Time.deltaTime,0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            activated=true;
    }
    private void onTriggerExit(Collider other)
    {
     if(other.gameObject.CompareTag("Player"))
            activated=false;   
    }
}
