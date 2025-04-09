using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Parameters")]
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 10f;
    
    [Header("Ground Check")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isGrounded;
    private float horizontalInput;
    private bool facingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // Jump when grounded and jump button pressed
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Ensure touch/mobile input works well for web
        #if UNITY_WEBGL || UNITY_IOS || UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            
            if (touch.phase == TouchPhase.Began)
            {
                // Jump when player touches the screen
                if (isGrounded)
                {
                    rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                }
            }
        }
        #endif

        // Flip the character when changing direction
        if ((horizontalInput > 0 && !facingRight) || (horizontalInput < 0 && facingRight))
        {
            Flip();
        }
    }

    private void FixedUpdate()
    {
        // Check if player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Move the player horizontally
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);
    }

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle platform collision
        if (collision.gameObject.CompareTag("Platform"))
        {
            // Optional: Add specific platform collision behavior here
            Debug.Log("Player landed on a platform");
        }
    }
}
