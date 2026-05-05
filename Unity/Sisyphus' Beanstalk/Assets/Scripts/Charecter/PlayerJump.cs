using System.Linq.Expressions;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

//  for the jump force
    public float jumpForce;
    public int jumpForceChargeRate;
    public int jumpForceMaxCharge = 10;


//  for the vertical jumping distance
    public float jumpDistance;
    public float jumpDistanceRate;
    public int  jumpHeightMax = 10;

    public Rigidbody2D rb;

    public Animator animator;
    private bool isFacingRight;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isFacingRight = true;
    }

    private void Update()
    {
        jumping();
        if(!isFacingRight && transform.position.x < 0)
        {
            Flip();
        }
        else if(isFacingRight && transform.position.x > 0)
        {
            Flip();
        }
    }


    void jumping()
    {
        Vector2 side = Vector2.zero;

        if (Input.GetKey(KeyCode.Space))
        {
            // if Space is held down, the jump force is charging up
            jumpForce += jumpForceChargeRate * Time.deltaTime;
            jumpDistance += jumpForceChargeRate * Time.deltaTime;
            animator.SetBool("Spacebar", true); 

            // sets the jump force to be limited to max distance
            if (jumpForce > jumpForceMaxCharge)
            {
                jumpForce = jumpForceMaxCharge;
                Debug.Log("jump force max");
            }

            // sets the jump height to be limited to max force
            if (jumpDistance > jumpHeightMax)
            {
                jumpDistance = jumpHeightMax;
                Debug.Log("jump height max");
            }



            // Debug.Log("charging");

        }
        else
        {
            animator.SetBool("Spacebar", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            FMODUnity.RuntimeManager.PlayOneShot("event:/charging", transform.position);
        }

            // checks to see which side the player is on to know what direction to go towards
            if (transform.position.x > 0)
        {
            side = new Vector2(-1, 0);
        }
        else if (transform.position.x < 0)
        {
            side = new Vector2(1f,0);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            // if W is released, thje player jumps to either side * the force they charged up

            rb.linearVelocity = new Vector2(side.x * jumpDistance, jumpForce);
            jumpForce = 0;
            jumpDistance = 0;
            Debug.Log("jumping");
            FMODUnity.RuntimeManager.PlayOneShot("event:/jump", transform.position);
        }
    }

    public void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
