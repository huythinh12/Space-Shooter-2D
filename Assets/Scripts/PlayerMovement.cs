using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Vector3 desiredPosition;

    // Update is called once per frame
    void Update()
    {
        desiredPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        desiredPosition.z = 0;
        desiredPosition.y += 1f;

        var distance = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, desiredPosition, distance);
    }
}
