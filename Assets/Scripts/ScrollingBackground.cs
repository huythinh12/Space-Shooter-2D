using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y -= speed * Time.deltaTime;
        if (newPosition.y <= -10f)
        {
            newPosition.y += 20f;
        }
        transform.position = newPosition;
    }
}
