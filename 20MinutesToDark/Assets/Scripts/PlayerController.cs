using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward *( speed * 10));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * (speed * 10));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * (speed * 10));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * (speed * 10));
        }

    }
}
