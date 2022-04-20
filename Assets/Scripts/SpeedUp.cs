using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            collision.gameObject.GetComponent<Player>().thrustH*=3;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            collision.gameObject.GetComponent<Player>().thrustH /= 3;
        }
    }
}
