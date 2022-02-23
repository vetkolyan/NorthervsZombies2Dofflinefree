using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Player : MonoBehaviour
{
    public Rigidbody2D Rigidbody2D;
    public BoxCollider2D BoxCollider2D;
    [SerializeField] private float _force = 3f;
    [SerializeField] private LayerMask _layerMask;
    public GameObject gameOverText, restartButton, blood;

    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }

    public void Jump()
    {
        if (this.IsGnd())
        {
            this.Rigidbody2D.velocity = (new Vector2(this.Rigidbody2D.velocity.x, this._force));
        }
    }

    public void Run(bool left)
    {
        var quaternion = left ? 180 : 0;
        var force = left ? -1 * this._force : this._force;
        this.Run(quaternion, force);
    }

    private void Run(int quaternion, float force)
    {
        this.transform.localRotation = Quaternion.Euler(0, quaternion, 0);
        this.Rigidbody2D.velocity = new Vector2(force, this.Rigidbody2D.velocity.y);
    }

    private bool IsGnd()
    {
        RaycastHit2D rc2d = Physics2D.BoxCast(this.BoxCollider2D.bounds.center, this.BoxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, this._layerMask);
        return rc2d.collider != null;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            Instantiate(blood, transform.position, Quaternion.identity);
            gameObject.SetActive(false);
        }
    }
}