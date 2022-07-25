using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingWithStuff : MonoBehaviour
{
    
    [SerializeField] private int playerHealth = 3;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Hazard"))
        {
            playerHealth -= 1;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.CompareTag("Hazard"))
            Debug.Log("I probably should not have touched that.");
    }
    //private void OnCollisionStay(Collision other)
    //{
        //float shrinkRate=0.1f *Time.deltaTime;
        //if(other.gameObject.tag != "Ground")
        //{
            //transform.localScale -= new Vector3(shrinkRate, shrinkRate, shrinkRate);
        //}
    //}
}
