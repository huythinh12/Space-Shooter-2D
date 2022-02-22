using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public float coolDownTime;

    private float counter;

    public GameObject bulletTemplate;

    // Update is called once per frame
    void Update()
    {
        counter = counter + Time.deltaTime;
        if (counter > coolDownTime)
        {
            Instantiate(bulletTemplate, transform.position, transform.rotation);
            counter = 0;
        }
    }
}
