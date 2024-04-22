using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunOnWalls : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pathpoints;
    private int index;
    private Vector3 actualPosition;
    public float speed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        index = 0;

    }

    private void Update()
    {
        actualPosition = transform.position;
        transform.position = Vector3.MoveTowards(actualPosition, pathpoints[index].transform.position, speed * Time.deltaTime);
        if (actualPosition == pathpoints[index].transform.position)
        {
            index++;
            if (index > 3)
            {
                index = 0; 
            }
        }
    }
}
