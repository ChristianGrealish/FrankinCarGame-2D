using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carjump : MonoBehaviour
{
    public float playerSpeed;
   
    public float maxSpeed = 5f;
    public Vector3 velocity = Vector3.zero;
    public float fowardSpeed = 1f;
    public Rigidbody2D rb;
    public Rigidbody2D rb1;
    public List<wheelGrounded> listofwheels;
    public float thrust = 1f;
   private bool didPress = false;
    private bool onTheGround;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            didPress = true;
        }
        else
        {
            didPress = false;
        }
        onTheGround = false;
        foreach(wheelGrounded currentWheel in listofwheels)
        {
            if (currentWheel.isGrounded)
            {
                onTheGround = true;
            }
        }
    }

    void FixedUpdate()
    {

        if (onTheGround)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        }

        velocity.x = fowardSpeed;
        transform.position += velocity * Time.deltaTime;
        if (didPress == true)
        {
            {

                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                rb1.AddForce(transform.up * thrust, ForceMode2D.Impulse);
                rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
               
            }
            
            float amntToMove1 = playerSpeed * Time.deltaTime;
            transform.Translate(Vector3.up * amntToMove1);
        }

        //gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
        velocity = Vector3.ClampMagnitude(velocity, maxSpeed);
        transform.position += velocity * Time.deltaTime;
    }
}




