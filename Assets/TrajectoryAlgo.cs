using UnityEngine;

public class TrajectoryAlgo : MonoBehaviour
{
    [Header("Target & Orbit Settings")]
    public Transform earthTarget;
    public float orbitSpeed = 5.0f;
    public Vector3 orbitAxis = Vector3.up;

    [Header("Vertical Oscillation Settings")]
    public float amplitude = 0.5f;
    public float frequency = 1.0f;

    void Update()
    {
        if (earthTarget == null) return;
        float verticalVelocity = Mathf.Cos(Time.time * frequency) * amplitude * frequency;
        transform.RotateAround(earthTarget.position, orbitAxis, orbitSpeed * Time.deltaTime);
        transform.position += Vector3.up * (verticalVelocity * Time.deltaTime);
    }
}
