using UnityEngine;
using UnityEngine.InputSystem;

public class playerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // float horizontalMove = 0f;
    // public float runSpeed = 40f; 
    [SerializeField] private InputActionReference movement;
    public float moveSpeed = 5f;
    private Vector2 movementInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // horizontalMove= Input.GetAxisRaw("Horizontal") * runSpeed;
        movementInput = movement.action.ReadValue<Vector2>();
        Vector3 move = new Vector3(movementInput.x, movementInput.y, 0f);
        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
    void FixedUpdate()
    {
        // controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
