using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movement_speed = 5.0f;
    private Rigidbody2D rb;
    private Vector2 vector_movement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        vector_movement.x = Input.GetAxisRaw("Horizontal");
        vector_movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + vector_movement * movement_speed * Time.fixedDeltaTime);
    }
}
