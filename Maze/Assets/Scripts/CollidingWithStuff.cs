using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidingWithStuff : MonoBehaviour
{
    [SerializeField] private int playerHealth = 3;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Hazard")
        {
            playerHealth -= 1;
            Debug.Log("Player Health: "+playerHealth);
            Debug.Log("I probably should not touch that.");
        }
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
