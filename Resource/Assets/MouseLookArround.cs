using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookArround : MonoBehaviour
{
    float rotationx = 0f;
    float rotationy = 0f;
    public float sentitive = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationx += Input.GetAxis("Mouse X") * sentitive;
        rotationy += Input.GetAxis("Mouse Y") * sentitive;
        transform.localEulerAngles = new Vector3(rotationx, rotationy, 0);
    }
}
