using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField]scoremanagr scoremanagr;
    [SerializeField] GameOverManagr gameOverManagr;
   private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Debug.Log("Game Over");

            gameOverManagr.SetGameOver();

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("point"))
        {
            Debug.Log("Add point");

            scoremanagr.addpoint();
        }   
    }
}
