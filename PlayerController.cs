using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;         // سرعت حرکت
    public Rigidbody2D rb;               // Rigidbody شخصیت
    public Joystick joystick;            // Joystick لمسی

    Vector2 movement;

    void Update()
    {
        // گرفتن ورودی از joystick
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;
    }

    void FixedUpdate()
    {
        // حرکت روان با Rigidbody
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
