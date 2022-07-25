using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLineTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.localScale = other.transform.localScale + new Vector3(5,5,5);
        }
    }
    private void OnTriggerExit(Collider other)
    {
     if(other.gameObject.tag == "Player")
        {
            other.transform.localScale = other.transform.localScale - new Vector3(5,5,5);
        }   
    }
}
