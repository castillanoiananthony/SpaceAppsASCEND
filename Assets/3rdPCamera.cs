using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    [Header("Target & Offsets")]
    public Transform target;
    public Vector3 offset = new Vector3(0.0f, 3.0f, -10.0f);
    public float smoothSpeed = 5.0f;
    public float lookSmoothSpeed = 10.0f;

    void LateUpdate()
    {
        if (target == null) return;
        Vector3 desiredPosition = target.TransformPoint(offset);
        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        Quaternion targetRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, lookSmoothSpeed * Time.deltaTime);
    }
}
