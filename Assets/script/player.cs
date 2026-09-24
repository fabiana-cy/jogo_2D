using System.Runtime.CompilerServices;
using UnityEditor.UI;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    private bool isGrounded = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
           
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");//Vai reconhecer o movimento horizontal
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);//Vai aplicar a velocidade ao movimento x e y

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, 15f), ForceMode2D.Impulse);//basicamente essa linha de código vai fazer nosso pleyer pular o forcemode2d.impulse, oque tá antes dele é a força dele e ele é o impulso écomo um soco o Forcemode é o movimento
            //e o new vector é a força desse soco, que no caso é 5 e é para cima.

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; //vai reconhecer quando o jogador está no chão.
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

}
