using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [Header("Movement Parameters")]
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float patrolDistance = 3f;

    private Vector3 startPosition;
    private bool movingRight = true;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        startPosition = transform.position;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Calculate patrol boundaries
        float rightBoundary = startPosition.x + patrolDistance;
        float leftBoundary = startPosition.x - patrolDistance;

        // Patrol movement
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            
            // Change direction at right boundary
            if (transform.position.x >= rightBoundary)
            {
                movingRight = false;
                FlipSprite();
            }
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            
            // Change direction at left boundary
            if (transform.position.x <= leftBoundary)
            {
                movingRight = true;
                FlipSprite();
            }
        }
    }

    private void FlipSprite()
    {
        if (spriteRenderer != null)
        {
            spriteRenderer.flipX = !spriteRenderer.flipX;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Handle collision with player
        if (collision.gameObject.CompareTag("Player"))
        {
            // Handle player-enemy collision
            // Could trigger player damage or death here
            Debug.Log("Player collided with enemy");
        }
    }
}
