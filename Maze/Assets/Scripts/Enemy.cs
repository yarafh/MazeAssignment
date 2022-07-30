using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Update is called once per frame
    private void FixedUpdate()
    {

    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(hit.gameObject.tag == "Enemy")
        {
            Destroy(hit.gameObject);
            Debug.Log("Enemy Defeated!");
        }
    }
}