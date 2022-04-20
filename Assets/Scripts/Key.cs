using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    Player Player;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Player)
        {
            if(Player.hasKey == true)
            {
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Player = collision.gameObject.GetComponent<Player>();
            Player.isTriggerWithKey = true;
        
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            Player = collision.gameObject.GetComponent<Player>();
            Player.isTriggerWithKey = false;
        }
    }
}
