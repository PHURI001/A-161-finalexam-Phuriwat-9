using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed { get; private set; }
    private float jumpForce = 10f;

    public bool IsInvulnerable { get; private set; }

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IsInvulnerable = false;
    }

    private void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void SetMoveSpeed(float newSpeed)
    {
        MoveSpeed = newSpeed;
        Debug.Log($"New Speed Is {MoveSpeed}");
    }

    public void SetInvulnerability(bool isEnabled)
    {
        IsInvulnerable = isEnabled;
        Debug.Log($"New IsInvulnerable Is {IsInvulnerable}");
    }
}
