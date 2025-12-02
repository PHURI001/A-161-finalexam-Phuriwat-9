using UnityEngine;

public class Player : MonoBehaviour
{
    //add
    [ field : SerializeField ] public int Health { get; private set; }

    //default
    [field: SerializeField] public float MoveSpeed { get; private set; }
    private float jumpForce = 10f;

    [field: SerializeField] public bool IsInvulnerable { get; private set; }

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IsInvulnerable = false;
        MoveSpeed = 5f;
        Health = 100;
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
        MoveSpeed = MoveSpeed * newSpeed;
        Debug.Log($"New Speed Is {MoveSpeed}");
    }

    public void SetInvulnerability(bool isEnabled)
    {
        IsInvulnerable = isEnabled;
        Debug.Log($"New IsInvulnerable Is {IsInvulnerable}");
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        PowerUpBase powerUpBase = collision.GetComponent<PowerUpBase>();
        powerUpBase.ApplyEffect(this);
    }

    /*public void Move() { }
    public void Jump() { }*/

    //add
    public void AddHealth(int newHealth)
    {
        Debug.Log($"Current Health : {Health}");
        Health += newHealth;
        Debug.Log($"After Buff Health : {Health}");
    }
}
