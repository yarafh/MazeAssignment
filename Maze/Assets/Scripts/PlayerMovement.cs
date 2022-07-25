using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float speed = 15;

    // Awake is called during initialization
    private void Awake()
    {
        //Debug.Log("Awake's debug message");
    }
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start's debug message");
        playerRigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        //Debug.Log("Called every 20 milliseconds");
        // Move left and right
        float xInput = Input.GetAxisRaw("Horizontal") * speed;
        // Move forward and backward
        float zInput = Input.GetAxisRaw("Vertical") * speed;
        Vector3 movement = new Vector3(xInput, 0, zInput);
        playerRigidbody.velocity = movement;
    }
    private void LateUpdate()
    {
        //Debug.Log("LateUpdate's debug message");
    }
    void Respawn()
    {

    }
}

