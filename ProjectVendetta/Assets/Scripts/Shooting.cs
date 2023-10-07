using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class Shooting : MonoBehaviour
{

    public Transform xPoint;
    public Transform negXPoint;
    public Transform yPoint;
    public Transform negYPoint;
    public GameObject bullet;

    [SerializeField] AudioClip shotNoise;

    Rigidbody2D rb;
    Transform bulletRot;

    Vector2 input;

    float bulletLife = 2.5f;
    public float shotSpeed = 200f;

   void FixedUpdate()
   {
        if (input.x <= 1 && input.x > 0)
        {
            //Debug.Log("Right");
            bullet = Instantiate(bullet, xPoint.position, transform.rotation) as GameObject;
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right * shotSpeed);
            AudioSource.PlayClipAtPoint(shotNoise, Camera.main.transform.position);

        }
        else if(input.x >= -1 && input.x < 0)
        {
            //Debug.Log("Left");
            bullet = Instantiate(bullet, negXPoint.position, transform.rotation) as GameObject;
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(-transform.right * shotSpeed);
            bulletRot = bullet.GetComponent<Transform>();
            bulletRot.Rotate(0, 0, 180);
            AudioSource.PlayClipAtPoint(shotNoise, Camera.main.transform.position);
        }
        
        if(input.y <= 1 && input.y > 0)
        {
            //Debug.Log("Up");
            bullet = Instantiate(bullet, yPoint.position, transform.rotation) as GameObject;
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * shotSpeed);
            bulletRot = bullet.GetComponent<Transform>();
            bulletRot.Rotate(0, 0, 90);
            AudioSource.PlayClipAtPoint(shotNoise, Camera.main.transform.position);
        }
        else if(input.y >= -1 && input.y < 0)
        {
            //Debug.Log("Down");
            bullet = Instantiate(bullet, negYPoint.position, transform.rotation) as GameObject;
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(-transform.up * shotSpeed);
            bulletRot = bullet.GetComponent<Transform>();
            bulletRot.Rotate(0, 0, 270);
            AudioSource.PlayClipAtPoint(shotNoise, Camera.main.transform.position);
        }
   }

   public void ReceiveInput(Vector2 _input)
   {
       input.x = _input.x;
       input.y = _input.y;
       //Debug.Log(input);
    }
}
