using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class nextfase : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            int cenaAtualIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(cenaAtualIndex + 1);
        }
    }
}
