using UnityEngine;

public class Player_Anim_Manager : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("YVelocity", rb.linearVelocityY);

        if(rb.linearVelocityY == 0)
        {
            animator.SetTrigger("Landing");
        }
    }
}
