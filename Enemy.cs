using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public  HealthBar HealthBar;
    public GameObject deathEffect;

    void Awake()
    {
        HealthBar = GetComponent<HealthBar>();
    }

    public void TakeDamege (int damage)
    {
        health -= damage;
        
        if (health <= 0)
        {
            Die();
        }
        HealthBar?.SetMaxHealth(health / 100f);
    }

    void Die ()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
