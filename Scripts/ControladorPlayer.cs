using UnityEngine;

public class ControladorPlayer : MonoBehaviour
{
    [Header("Movimiento")]
    public float moveSpeed = 5f;     // Velocidad de movimiento
    public float jumpForce = 12f;    // Fuerza del salto

    [Header("Ground Check")]
    public Transform groundCheck;    // Un GameObject vacío en los pies del personaje
    public float groundCheckRadius = 0.2f; // Radio para detectar suelo
    public LayerMask groundLayer;    // Capa asignada al suelo

    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // --- Movimiento lateral ---
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // --- Comprobar si toca suelo ---
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // --- Salto con la tecla W ---
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }

        // --- Flip del personaje ---
        if (moveInput > 0)
            transform.localScale = new Vector3(1, 1, 1);
        else if (moveInput < 0)
            transform.localScale = new Vector3(-1, 1, 1);
    }

    void OnDrawGizmosSelected()
    {
        // Dibuja el círculo de groundCheck en la vista del editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
