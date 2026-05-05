using System.Linq.Expressions;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public float jumpForce;
    public int jumpForceChargeRate = 2;
    public int jumpForceMaxCharge = 7;



    public float jumpDistance;
    public float jumpDistanceRate = 2;
    public int  jumpHeightMax = 7;

    public Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        jumping();
    }


    void jumping()
    {
        Vector2 side = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            // if W is held down, the jump force is charging up
            jumpForce += jumpForceChargeRate * Time.deltaTime;
            jumpDistance += jumpForceChargeRate * Time.deltaTime;

            if (jumpForce > jumpForceMaxCharge)
            {
                jumpForce = jumpForceMaxCharge;
            }

            // sets the 
            if (jumpDistance > jumpHeightMax)
            {
                jumpDistance = jumpHeightMax;
            }


            Debug.Log("charging");

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

        if (Input.GetKeyUp(KeyCode.W))
        {
            // if W is released, thje player jumps to either side * the force they charged up

            rb.linearVelocity = new Vector2(side.x * jumpDistance, jumpForce);
            jumpForce = 0;
            jumpDistance = 0;
            Debug.Log("jumping");
        }
    }
}
