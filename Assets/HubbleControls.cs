using UnityEngine;
using UnityEngine.InputSystem;

public class HubbleController : MonoBehaviour
{
    [Header("Movement Speed")]
    public float moveSpeed = 15.0f;
    public float verticalSpeed = 10.0f;
    public float rotationSpeed = 100.0f;

    void Update()
    {
        Keyboard kb = Keyboard.current;
        if (kb == null) return;

        float moveForward = 0.0f;
        float moveStrafe = 0.0f;

        if (kb.wKey.isPressed) moveForward += moveSpeed * Time.deltaTime;
        if (kb.sKey.isPressed) moveForward -= moveSpeed * Time.deltaTime;
        if (kb.dKey.isPressed) moveStrafe += moveSpeed * Time.deltaTime;
        if (kb.aKey.isPressed) moveStrafe -= moveSpeed * Time.deltaTime;

        float moveVertical = 0.0f;
        if (kb.rKey.isPressed) moveVertical += verticalSpeed * Time.deltaTime;
        if (kb.fKey.isPressed) moveVertical -= verticalSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * moveForward + Vector3.right * moveStrafe + Vector3.up * moveVertical);

        if (kb.qKey.isPressed) transform.Rotate(Vector3.up, -rotationSpeed * Time.deltaTime);
        if (kb.eKey.isPressed) transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
