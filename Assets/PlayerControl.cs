using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 6f;
    public float jumpspeed = 2f;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Debug.Log(moveHorizontal);
        float moveVertical = Input.GetAxis("Vertical");
        Debug.Log(moveVertical);

        Vector3 movement = new Vector3(moveHorizontal*speed, rb.velocity.y, moveVertical*speed);
        rb.velocity = movement;    

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpspeed);
        }
    }
}