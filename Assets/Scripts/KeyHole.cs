using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHole : MonoBehaviour
{
    // Start is called before the first frame update
    Player Player;
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
            Player = collision.gameObject.GetComponent<Player>();
            Player.isTriggerWithKeyHole = true;

        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Player = collision.gameObject.GetComponent<Player>();
            Player.isTriggerWithKeyHole = false;
        }
    }
}
