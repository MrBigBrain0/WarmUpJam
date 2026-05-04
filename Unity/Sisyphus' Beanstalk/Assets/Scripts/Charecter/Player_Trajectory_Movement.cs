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
        if (Input.GetMouseButtonDown(0))
            startDragPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonUp(0))
        {
            Vector2 endDragPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 jumpVelocity = (endDragPos - startDragPos) * force;

            rb.linearVelocity = jumpVelocity;
        }
    }
}
