using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class Player_Trajectory_Movement : MonoBehaviour
{
    public float force = 5;
    public Rigidbody2D rb;

    Vector2 startDragPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // If the left mouse button clicks and drags, it prepares for it to move in that direction

        if (Input.GetMouseButtonDown(0))
            startDragPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // if the left mouse button is let go, the player launches from its starting position in the direction where the user dragged it.
        if (Input.GetMouseButtonUp(0))
        {
            Vector2 endDragPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // takes the players rigidbody and moves it with the end position - start positon * its force which affects its speed
            Vector2 jumpVelocity = (endDragPos - startDragPos) * force;

            rb.linearVelocity = jumpVelocity;
        }
    }
}
