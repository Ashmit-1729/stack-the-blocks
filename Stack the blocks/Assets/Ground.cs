using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class Ground : MonoBehaviour
{
//     private bool isFirstPlank = true; // Flag to track if the first plank has collided

//     // Collision detection with planks
//     private void OnCollisionEnter(Collision collision)
//     {
//         // Check if the collision is with a plank
//         if (collision.gameObject.CompareTag("plank"))
//         {
//             // If it's not the first plank that collided, trigger game over
//             if (!isFirstPlank)
//             {
//                 GameOver();
//             }
//             else
//             {
//                 // Set isFirstPlank to false after the first plank collision
//                 isFirstPlank = false;
//             }
//         }
//     }

//     // Method to trigger game over
//     void GameOver()
//     {
//         // You can add additional game over logic here if needed

//         // Load the game over scene (adjust the scene name accordingly)
//         SceneManager.LoadScene("end scene");
//     }
// 
}
