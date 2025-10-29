using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sr;

    [Header("Movement Settings")]
    public float speed = 5f;

    void Start()
    {
        // Lấy component Rigidbody2D và SpriteRenderer trên nhân vật
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // Nhận input ngang (A, D hoặc phím mũi tên)
        float horizontal = Input.GetAxisRaw("Horizontal");

        // Gán vận tốc theo hướng ngang
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        // Đảo hướng nhân vật khi di chuyển
        if (horizontal != 0)
        {
            sr.flipX = horizontal < 0;
        }
    }
}
