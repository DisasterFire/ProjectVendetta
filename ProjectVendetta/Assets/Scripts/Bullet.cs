using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] float bulletLifetime = 3.0f;

    // The velocity of the bullet.
    public Vector2 Velocity;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Velocity * Time.deltaTime;

        if (bulletLifetime > 0)
        {
            bulletLifetime -= 1f * Time.deltaTime;
            Debug.Log(gameObject.transform.position);
        }
        else if(bulletLifetime < 0) 
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Wall")
        {
            Destroy(gameObject);
        }
        
        
    }
}
