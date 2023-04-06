using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDepl : MonoBehaviour
{
    public float pos;

    void Update()
    {
        transform.position = new Vector3(transform.position.x-0.05f, transform.position.y, transform.position.z);
        if (transform.position.x < -10)
        {
            transform.position = new Vector3(6, Random.Range(-4, 4), 6);
        }
    }

    public void Stop()
    {
        transform.position = new Vector3(pos, 0f, 6f);
    }
}
