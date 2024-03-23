using UnityEngine;

public class СharacterMover : MonoBehaviour
{
    [SerializeField] private AudioSource stepSound;
    [SerializeField] private float speed;
    private SpriteRenderer sprite;
    private BoxCollider2D spriteCollider;
    private Animator animator;
    private float verticalDirection;
    private float horizontalDirection;

    private void Start()
    {
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        spriteCollider = GetComponent<BoxCollider2D>();
    }


    private void Update()
    {
        Move();
        sprite.enabled = true; //Don't know why, but sprite.enable = false, when Destry() of any object called
    }

    private void Move()
    {
        horizontalDirection = Input.GetAxis("Horizontal");
        verticalDirection = Input.GetAxis("Vertical");

        transform.Translate(horizontalDirection * speed * Time.deltaTime * Vector2.right);
        transform.Translate(verticalDirection * speed * Time.deltaTime * Vector2.up);

        animator.SetBool("isMoving", (horizontalDirection != 0 || verticalDirection != 0) ? true : false);

        if (animator.GetBool("isMoving"))
        {
            if (stepSound.isPlaying) { return; }
            else { stepSound.Play(); }
        }

        if (horizontalDirection < 0)
        {
            sprite.flipX = true;
            spriteCollider.offset = new Vector2(-0.33f, 0.18f);
        }
        else if (horizontalDirection > 0)
        {
            sprite.flipX = false;
            spriteCollider.offset = new Vector2(0.33f, 0.18f);
        }
    }
}
