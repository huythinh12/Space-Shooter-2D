using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        var newPosition = transform.position;
        var distance = speed * Time.deltaTime;
        newPosition.y = newPosition.y + distance;
        transform.position = newPosition;
    }
}
