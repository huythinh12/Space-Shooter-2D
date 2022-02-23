using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private bool isAttack;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("WaitingToAttack");
    }

    // Update is called once per frame
    void Update()
    {
        if (isAttack)
        {
            transform.Translate(Vector2.down * Time.deltaTime * 10f);

        }
    }

    public IEnumerator WaitingToAttack()
    {
        yield return new WaitForSeconds(Random.RandomRange(0, 4));
        isAttack = true;
        Destroy(gameObject, 10f);
    }
}
