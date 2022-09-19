using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardControl : MonoBehaviour
{
    public float speed = 10.0f;
    public float jumpForce = 10.0f;
    public Rigidbody rb;

    public GameObject ground;
    public bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddTorque(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddTorque(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(-1 * speed * Time.deltaTime, 0, 0 );
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(1 * speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (isGrounded)
            {
                isGrounded = false;
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
            
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == ground)
        {
            isGrounded = true;
        }    
    }
}

