using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{

    public Transform xPoint;
    public Transform negXPoint;
    public Transform yPoint;
    public Transform negYPoint;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        fireGun();
    }

    void fireGun()
    {   

        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, xPoint.position, transform.rotation);
        }

        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, negXPoint.position, transform.rotation);
            Debug.Log("Boom!");
        }

        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, yPoint.position, transform.rotation);
            Debug.Log("Kapow!");
        }

        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            Instantiate(bullet, negYPoint.position, transform.rotation);
            Debug.Log("Zap");
        }
    }
}
