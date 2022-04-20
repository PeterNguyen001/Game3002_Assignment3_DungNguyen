using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float moveSpeed = 100f;
    public float thrust = 20.0f;
    public float thrustH = 20.0f;

    public LayerMask groundLayer;


    bool isGrounded;
    public bool hasKey = false;
    public bool isTriggerWithKey;
    public bool isTriggerWithKeyHole;
    public bool open;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.zero;

        isGrounded = IsGrounded();

        if (Input.GetAxis("Right") == 1)
        {


            rb.AddForce(transform.right * thrustH, ForceMode2D.Impulse);
        }
        if (Input.GetAxis("Up") == 1 && isGrounded )
        {

            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
        if (Input.GetAxis("Left") == 1)
        {


            rb.AddForce(-transform.right * thrustH, ForceMode2D.Impulse);
        }

        if(Input.GetAxis("Pick Up") == 1 && isTriggerWithKey)
        {
            hasKey = true;
        }

        if (Input.GetAxis("Pick Up") == 1 && isTriggerWithKeyHole && hasKey)
        {
            open = true;
        }

    }

    bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.1f;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        if (hit.collider != null)
        {
            return true;
        }

        return false;
    }

 

}