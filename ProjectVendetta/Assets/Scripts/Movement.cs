using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] public float speed = 11f;
    Vector2 input;

    void Start()
    {

    }

    void Update()
    {
        Vector2 velocity = (transform.right * input.x + transform.up * input.y) * speed;
        controller.Move(velocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _input)
    {
        input = _input;
    }
}
