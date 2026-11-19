using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptvitoria : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(3);
        }
    }
}
