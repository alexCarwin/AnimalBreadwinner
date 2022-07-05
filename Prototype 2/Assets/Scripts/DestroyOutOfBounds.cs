using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float zRange = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < -zRange)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
