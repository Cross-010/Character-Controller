using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;
    public float maxHealth;
    public float currentHealth;

    private CharacterController controller;
    public Animator animator;
    private Vector3 velocity;
    private bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();

        currentHealth = maxHealth;
    }

    void Update()
    {
        isGrounded = controller.isGrounded;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        if (move.magnitude > 0.1f)
        {
            Quaternion rotation = Quaternion.LookRotation(move);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 6f * Time.deltaTime);
        }

        controller.Move(move * speed * Time.deltaTime);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f; // Stick the player to the ground when grounded
        }

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight - 2f * gravity);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }

    }
}



