using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class Aiming : MonoBehaviour
{
    //[SerializeField] public float speed = 11f;
    Vector2 input;

    public GameObject CursorPOS;

    Vector2 screenMousePos;
    Vector2 mousePos;

    public Vector3 offset;

    Ray rayPOS;

    public Shooting gun;

    void Start()
    {
        
    }

    private void Update()
    {
        mousePos = Input.mousePosition;

        screenMousePos = Camera.main.ScreenToWorldPoint(mousePos);

        CursorPOS.transform.position = screenMousePos;     

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }
    }

    public void ReceiveInput(Vector2 _input)
    {
        input.x = _input.x;
        input.y = _input.y;
    }


    void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 direction = CursorPOS.transform.position;

            Vector2 dir;
            dir.x = direction.x;
            dir.y = direction.y;

            direction.Normalize();

            GameObject newBullet = Instantiate(gun.bullet, dir, Quaternion.LookRotation(dir));
            Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();

            Transform bulletRot = newBullet.GetComponent<Transform>();
            bulletRot.Rotate(0,0,direction.z);

            rb.AddForce(dir * gun.shotSpeed);

            gun.gun.Play();
        }
    }

}
