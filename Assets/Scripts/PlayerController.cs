using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 2f;


    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check if player is grounded
        isGrounded = controller.isGrounded;

        //Get input for movement along the x and z axes
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        //Create a movement vector based on the input
        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        //Apply movement to the CharacterController
        controller.Move(move * speed * Time.deltaTime);

        //Apply gravity if player is not grounded
        if (isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        //Jump logic
        if (isGrounded && Input.GetButtonDown("Jump")){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        //Apply gravity to the player's vertical movement
        velocity.y += gravity * Time.deltaTime;

        //Apply the velocity to the character controller
        controller.Move(velocity * Time.deltaTime);
    }
}
