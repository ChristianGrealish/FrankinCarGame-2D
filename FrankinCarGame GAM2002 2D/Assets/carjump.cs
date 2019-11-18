using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carjump : MonoBehaviour
{
    public float playerSpeed;
    public Vector3 gravity;
    public float maxSpeed = 5f;
    public Vector3 velocity = Vector3.zero;
    public float fowardSpeed = 1f;
    public Rigidbody2D rb;
    public float thrust = 1f;
   private bool didPress = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetMouseButton(0))
        {
            didPress = true;
        }
        else
        {
            didPress = false;
        }
    }

    void FixedUpdate()
    {
        velocity.x = fowardSpeed;
        transform.position += velocity * Time.deltaTime;
        if (didPress == true)
        {
            {
                rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
            }
            float amntToMove1 = playerSpeed * Time.deltaTime;
            transform.Translate(Vector3.up * amntToMove1);
        }
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;
    }
}




