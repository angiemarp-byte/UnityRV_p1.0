using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleRotate : MonoBehaviour
{
    float startY;

    void Start()
    {
        startY = transform.position.y;
    }

    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);

        float newY = startY + Mathf.Sin(Time.time * 2) * 0.2f;

        transform.position = new Vector3(
            transform.position.x,
            newY,
            transform.position.z
        );
    }
}