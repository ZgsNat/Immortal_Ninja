using UnityEngine;

public class BoxBounce : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 bladeVelocity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        bladeVelocity = rb.velocity;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name.Contains("Wall"))
        {
            var speed = bladeVelocity.magnitude;
            var direction = Vector3.Reflect(bladeVelocity.normalized, other.contacts[0].normal);
            direction.y = 0f;
            rb.velocity = direction * Mathf.Max(speed, 0f);
        }
        else
        {
            rb.velocity = bladeVelocity;
        };
    }
}
