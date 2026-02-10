using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    private CharacterController controller;
    private Vector2 moveInput;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    // 👇 ESTA es la firma correcta para "Send Messages"
    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 move = new Vector3(moveInput.x, 0, moveInput.y);
        controller.Move(move * speed * Time.deltaTime);
    }
}
