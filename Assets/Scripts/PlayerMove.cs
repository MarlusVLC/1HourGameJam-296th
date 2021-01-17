using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //public float speed = 10.0f;
    public float jumpForce = 10f;
    float horizontalAxis;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //horizontalAxis = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector2(speed * horizontalAxis, 0);

        if ((Input.GetKeyDown(KeyCode.Space)) || Input.GetKeyDown(KeyCode.Z) || Input.anyKeyDown)
        {
            rb.AddForce(new Vector2(0, -jumpForce), ForceMode2D.Impulse);

        }

        if (transform.position.x >= 10 || transform.position.x <= -10) 
        {
            transform.position = new Vector3(0, 0.5f, 0);
        }



        
    }

}
