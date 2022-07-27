using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    private FirstPersonController playerScript;
    private bool isFaster=false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject && (isFaster==false))
        {
            isFaster=true;
            playerScript=other.gameObject.GetComponent<FirstPersonController>();
            playerScript.moveSpeed+=10;
            playerScript.runSpeed+=10;
        }
    }
}
