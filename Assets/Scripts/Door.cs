using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Player Player;
    private Rigidbody2D rb;
    public float thrust = 2000.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.open == true)
        {
            rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }

    }
}
