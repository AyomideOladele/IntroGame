using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//We need this because without it, the ball only bounces vertically
public class BounceScript : MonoBehaviour
{
    public float BouncePower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Rigidbody rb = other.rigidbody; // ball rigid body
        float paddleX = transform.position.x; // x position of paddle
        float ballX = other.transform.position.x; // x positon of ball

        Vector3 forceVector = new Vector3(x: ballX - paddleX, y:1, z:0).normalized; // Don't care about magnitude, so normalise
        rb.AddForce(forceVector * BouncePower, ForceMode.VelocityChange);
        rb.useGravity = false; // Disables gravity once ball hit paddle
    }
}
