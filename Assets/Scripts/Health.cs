using UnityEngine;
public class Health : MonoBehaviour
{
    public GameObject explosionTemplate;
    public int healthPoint;
    public System.Action OnPlayerDied;

    void OnTriggerEnter2D(Collider2D collider)
    {
        healthPoint = healthPoint - 1;
        if (healthPoint <= 0 || collider.CompareTag("Player"))
        {
            var explosionObject = Instantiate(explosionTemplate, transform.position, transform.rotation);
            Destroy(explosionObject, 0.8f);
            Destroy(gameObject);
            if (OnPlayerDied != null)
            {
                OnPlayerDied();
            }  
        }
    }
  
}
