using System.Collections;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float force = 5f; // Adjust force for desired "shoot" distance/speed

    void Start()
    {
        // Generate a random direction vector within a unit sphere
        Vector3 randomDirection = Random.insideUnitSphere;
        randomDirection.y = 0f; // Restrict vertical movement (optional)
        randomDirection = randomDirection.normalized;

        // Apply force in the random direction
        GetComponent<Rigidbody>().AddForce(randomDirection * force, ForceMode.Impulse);
    }
}
