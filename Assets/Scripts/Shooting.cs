using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    public Transform xPoint;
    public Transform yPoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void fireGun()
    {

        /*
        if (sideFire >= 0.0)
        {
            Instantiate(bullet, xPoint.position, transform.rotation);
        }

        if (sideFire <= 0.0)
        {
            Instantiate(bullet, -xPoint.position, transform.rotation);
        }

        if (vertFire >= 0.0)
        {
            Instantiate(bullet, yPoint.position, transform.rotation);
        }

        if (vertFire >= 0.0)
        {
            Instantiate(bullet, -yPoint.position, transform.rotation);
        }

        */

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, xPoint.position, transform.rotation);
        }

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, -xPoint.position, transform.rotation);
            Debug.Log("Boom!");
        }

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, yPoint.position, transform.rotation);
            Debug.Log("Kapow!");
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, -yPoint.position, transform.rotation);
            Debug.Log("Zap");
        }
    }
}
