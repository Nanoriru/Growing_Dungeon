using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 15f;

    void Update()
    {
        Vector2 move = Vector2.zero;

        if (Keyboard.current.wKey.isPressed)
            move.y += 1;

        if (Keyboard.current.sKey.isPressed)
            move.y -= 1;

        if (Keyboard.current.aKey.isPressed)
            move.x -= 1;

        if (Keyboard.current.dKey.isPressed)
            move.x += 1;

        Vector3 direction = new Vector3(move.x, 0, move.y).normalized;

        transform.position += direction * moveSpeed * Time.deltaTime;
    }
}