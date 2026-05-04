using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

public class Death_Condition : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the player collides with the death floor then it sets off its trigger to reset the scene
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
