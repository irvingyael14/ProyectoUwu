using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 2.0f;
    public float rotationSpeed = 100.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Mueve el carro hacia adelante y atrás
        rb.velocity = transform.right * moveVertical * speed;

        // Gira el carro
        rb.angularVelocity = -moveHorizontal * rotationSpeed;
    }
}