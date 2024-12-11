using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // [SerializeField] CharacterController controller;

    Rigidbody2D rb;

    [SerializeField] public float speed = 11f;
    Vector2 input;

    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void FixedUpdate()
    {
        Vector2 velocity = (transform.right * input.x + transform.up * input.y) * speed;
        rb.velocity = velocity;
    }

    public void ReceiveInput(Vector2 _input)
    {
        input = _input;
    }
}
