using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastTime;
    private float delayBetweenAction = 1.0f;
    // Update is called once per frame
    void Update()
    {
        if (Time.time > lastTime + delayBetweenAction)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                lastTime = Time.time;
            }
        }
        // On spacebar press, send dog

    }
}
