using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{

    public Transform xPoint;
    public Transform negXPoint;
    public Transform yPoint;
    public Transform negYPoint;

    public GameObject laserBeam;
    public GameObject bullet;

    private GameObject inBullet;

    public bool usingPistol = true;
    public bool usingLaser = false;
    public bool usingBomb = false;

    [SerializeField] AudioClip shotNoise;
    [SerializeField] AudioClip laserNoise;

    public AudioSource gun;

    Rigidbody2D rb;
    Transform bulletRot;
    Transform laserRot;

    private bool rightShoot;
    private bool leftShoot;
    private bool upShoot;
    private bool downShoot;

    private bool fired = false;
    public float fireRate = 0.1f;

    private bool heldDown;
    private bool pressed;

    Vector2 input;

    float bulletLife = 2.5f;
    public float shotSpeed = 200f;

    public bool shotgun = false;
    public bool reverse = false;
    public bool grapple = false;

    public Vector3 offset;

    public float m_rotationOffsetIncrement;
    public float m_ringDiameter;
    public int m_particlesInRing;
    public float m_tangentSpeed;

    private void Awake()
    {
        rightShoot = input.x <= 1 && input.x > 0;
        leftShoot = input.x >= -1 && input.x < 0;
        upShoot = input.y <= 1 && input.y > 0;
        downShoot = input.y >= -1 && input.y < 0;
    }

    private void Update()
    {

        //Debug.Log(xPoint.position);
        //Debug.Log(negXPoint);
        //Debug.Log(yPoint);
        //Debug.Log(negYPoint);

        if (!fired)
        {
            if(Pistol())
            {
                fired = true;
                Invoke("Cooldown", fireRate);
            }
        }

        if(Input.GetKeyDown(KeyCode.Q))
        {
             usingPistol = false;
             //usingLaser = true;
             usingBomb = false;

            shotgun = true;
            fireRate = 1f;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            usingPistol = true;
            usingLaser = false;
            usingBomb = false;
            shotgun = false;
            fireRate = 0.5f;
        }
    }

    void FixedUpdate()
   {
        if (usingLaser)
        {
            Laser();
        }
   }

    void Fired()
    {
        fired = true;
    }

    void Cooldown()
    {
        fired = false;
    }

   public void ReceiveInput(Vector2 _input)
   {
       input.x = _input.x;
       input.y = _input.y;
       //Debug.Log(input);
    }

    public bool Pistol()
    {
        if(usingPistol)
        {
            if (input.x <= 1 && input.x > 0)
            {
                //Debug.Log("Right");
                inBullet = Instantiate(bullet, xPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.right * shotSpeed);
                gun.Play();

                Debug.Log(inBullet.transform.position);

                return rightShoot = true;
            }

            else if (input.x >= -1 && input.x < 0)
            {
                //Debug.Log("Left");
                inBullet = Instantiate(bullet, negXPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.right * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 180);
                gun.Play();

                return leftShoot = true;
            }

            if (input.y <= 1 && input.y > 0)
            {
                //Debug.Log("Up");
                inBullet = Instantiate(bullet, yPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 90);
                gun.Play();

                return upShoot = true;
            }
            else if (input.y >= -1 && input.y < 0)
            {
                //Debug.Log("Down");
                inBullet = Instantiate(bullet, negYPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 270);
                gun.Play();

                return downShoot = true;
            }

        }

        else if(shotgun)
        {
            //usingPistol = false;

            if (input.x <= 1 && input.x > 0)
            {
                //Debug.Log("Right");
                inBullet = Instantiate(bullet, xPoint.position, transform.rotation);
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.right * shotSpeed);
                gun.Play();

                

                inBullet = Instantiate(bullet, xPoint.position * offset.y, transform.rotation);
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.right * shotSpeed);
                gun.Play();

                inBullet = Instantiate(bullet, xPoint.position / offset.y, transform.rotation);
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.right * shotSpeed);

                gun.Play();

                //AudioSource.PlayClipAtPoint(shotNoise, Camera.main.transform.position);

                return rightShoot = true;
            }

            else if (input.x >= -1 && input.x < 0)
            {
                //Debug.Log("Left");
                inBullet = Instantiate(bullet, negXPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.right * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 180);
                gun.Play();

                inBullet = Instantiate(bullet, negXPoint.position * offset.y, transform.rotation);
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.right * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 180);
                gun.Play();

                inBullet = Instantiate(bullet, negXPoint.position / offset.y, transform.rotation);
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.right * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 180);
                gun.Play();

                return leftShoot = true;
            }

            if (input.y <= 1 && input.y > 0)
            {
                //Debug.Log("Up");
                inBullet = Instantiate(bullet, yPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 90);

                gun.Play();

                inBullet = Instantiate(bullet, yPoint.position * offset.x, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 90);

                gun.Play();

                inBullet = Instantiate(bullet, yPoint.position / offset.x, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 90);

                gun.Play();

                //AudioSource.Play("shotNoise");

                return upShoot = true;
            }
            else if (input.y >= -1 && input.y < 0)
            {
                //Debug.Log("Down");
                inBullet = Instantiate(bullet, negYPoint.position, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 270);
                gun.Play();

                inBullet = Instantiate(bullet, negYPoint.position * offset.x, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 270);
                gun.Play();

                inBullet = Instantiate(bullet, negYPoint.position / offset.x, transform.rotation) as GameObject;
                rb = inBullet.GetComponent<Rigidbody2D>();
                rb.AddForce(-transform.up * shotSpeed);
                bulletRot = inBullet.GetComponent<Transform>();
                bulletRot.Rotate(0, 0, 270);
                gun.Play();


                return downShoot = true;
            }
        }

        else if(usingBomb)
        {
            //usingPistol = false;

            if (input.x <= 1 && input.x > 0 || input.x >= -1 && input.x < 0 || input.y <= 1 && input.y > 0 || input.y >= -1 && input.y < 0)
            {
                //Debug.Log("Right");
                bullet = Instantiate(bullet, xPoint.position, transform.rotation);


                  gun.Play();

                //AudioSource.PlayClipAtPoint(shotNoise, Camera.main.transform.position);

                return rightShoot = true;
            }
        }

        return false;
    }

    public void Laser()
    {
        if (input.x <= 1 && input.x > 0)
        {
            //Debug.Log("Right");
            laserBeam = Instantiate(laserBeam, xPoint.position, transform.rotation) as GameObject;
            rb = laserBeam.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right * shotSpeed);
            AudioSource.PlayClipAtPoint(laserNoise, Camera.main.transform.position);
            laserRot = laserBeam.GetComponent<Transform>();
            laserRot.Rotate(0, 0, 180);
        }
        else if (input.x >= -1 && input.x < 0)
        {
            //Debug.Log("Left");
            laserBeam = Instantiate(laserBeam, negXPoint.position, transform.rotation) as GameObject;
            rb = laserBeam.GetComponent<Rigidbody2D>();
            rb.AddForce(-transform.right * shotSpeed);
            laserRot = laserBeam.GetComponent<Transform>();
            laserRot.Rotate(0, 0, 0);
            AudioSource.PlayClipAtPoint(laserNoise, Camera.main.transform.position);
        }

        if (input.y <= 1 && input.y > 0)
        {
            //Debug.Log("Up");
            laserBeam = Instantiate(laserBeam, yPoint.position, transform.rotation) as GameObject;
            rb = laserBeam.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * shotSpeed);
            laserRot = laserBeam.GetComponent<Transform>();
            laserRot.Rotate(0, 0, 270);
            AudioSource.PlayClipAtPoint(laserNoise, Camera.main.transform.position);
        }
        else if (input.y >= -1 && input.y < 0)
        {
            //Debug.Log("Down");
            laserBeam = Instantiate(laserBeam, negYPoint.position, transform.rotation) as GameObject;
            rb = laserBeam.GetComponent<Rigidbody2D>();
            rb.AddForce(-transform.up * shotSpeed);
            laserRot = laserBeam.GetComponent<Transform>();
            laserRot.Rotate(0, 0, 90);
            AudioSource.PlayClipAtPoint(laserNoise, Camera.main.transform.position);
        }
    }
}
