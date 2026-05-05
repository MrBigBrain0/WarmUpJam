using UnityEngine;

public class DeletePlatforms : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {


        // if the player reaches this trigger the previous platfrom below them is destroyed
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);

        }


    }
}
