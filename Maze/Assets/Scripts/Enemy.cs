using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Update is called once per frame
    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }

    private void LateUpdate()
    {
        Debug.Log("Enemy Defeated!");
    }
}