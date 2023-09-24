using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class GameOverManager : MonoBehaviour
{
    public float gameOverYThreshold = -5.0f; // Set the Y threshold for game over

    private bool isFirstPlank = true; // Flag to track if this is the first plank

    // Update is called once per frame
    void Update()
    {
        // Check if this is not the first plank and it has fallen below the threshold
        if (!isFirstPlank && (transform.position.y < gameOverYThreshold))
        {
            // The plank has fallen below the threshold, trigger game over
            GameOver();
        }
    }

    // Method to trigger game over
    void GameOver()
    {
        // Load the game over scene (adjust the scene name accordingly)
        SceneManager.LoadScene("end scene");
    }

    // Collision detection with the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if this is not the first plank and it collided with the ground
        if (!isFirstPlank && (collision.gameObject.CompareTag("ground")))
        {
            // A plank (other than the first) has collided with the ground, trigger game over
            GameOver();
        }

        // Set isFirstPlank to false after the first plank collision
        isFirstPlank = false;
    }
}
