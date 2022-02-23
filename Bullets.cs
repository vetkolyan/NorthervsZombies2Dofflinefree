using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullets : MonoBehaviour
{
    public float Speed = 27f;
    public int damage = 40;
    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * Speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
       Enemy enemy = hitInfo.GetComponent<Enemy>();
       if (enemy != null)
       {
            enemy.TakeDamege(damage);
       }

        Destroy(gameObject);
    }
}
