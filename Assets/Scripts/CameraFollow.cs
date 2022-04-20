using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform followTransform;
    public float moveSpeed = 50f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector3(followTransform.position.x, followTransform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y, this.transform.position.z);

        //if(transform.position.x < followTransform.position.x)
        //{
        //    rb.velocity = new Vector2(moveSpeed * Time.deltaTime, 0);
        //}
        //if (transform.position.x > followTransform.position.x)
        //{
        //    rb.velocity = new Vector2(-moveSpeed * Time.deltaTime, 0);
        //}

        //if (transform.position.y < followTransform.position.y-25)
        //{
        //    rb.velocity = new Vector2(0, moveSpeed * Time.deltaTime);
        //}

        //if (transform.position.y > followTransform.position.y+25)
        //{
        //    rb.velocity = new Vector2(0, -moveSpeed * Time.deltaTime);
        //}

    }
}