using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private int money = 0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            money++;
            Destroy(other.gameObject);
            Debug.Log("I have this much money: "+money);
        }
    }
    void LateUpdate()
    {
     //Debug.Log("I have this much money: "+money);   
    }
}
