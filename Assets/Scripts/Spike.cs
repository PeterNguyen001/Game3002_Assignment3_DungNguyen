using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform spawnPoint;
    public GameObject camera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            collision.gameObject.transform.position = spawnPoint.position;
            camera.transform.position = new Vector3(spawnPoint.position.x, spawnPoint.position.y, camera.transform.position.z);
        }
    }
}
