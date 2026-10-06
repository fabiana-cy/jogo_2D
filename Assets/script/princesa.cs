using UnityEngine;

public class princesa : MonoBehaviour
{
    public float forcapulo = 5f;
    private Rigidbody2D rb;
    private bool nochao;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.CompareTag("Ground"))// col.collider se refere ao colisor, no caso aqui reconhece quando está no chão.
            nochao = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (nochao)
        {
            rb.AddForce(new Vector2(0f, forcapulo), ForceMode2D.Impulse);
            nochao = false;
        }
    }
}
