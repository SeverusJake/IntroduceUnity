using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float speed = 8f;
    public float maxVelocity = 4f;

    public int maxJumps = 1;
    private int jumps;
    private float jumpForce = 2f;

    //[SerializeField]
    private Rigidbody2D myBody;
    private Animator anim;

    private bool moveLeft, moveRight, jumpUp;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveLeft)
        {
            MoveLeft();
        }

        if (moveRight)
        {
            MoveRight();
        }

        if (jumpUp)
        {
            Jump();
        }
    }

    public void SetJumpUp(bool jumpUp)
    {
        this.jumpUp = jumpUp;
    }

    public void SetMoveLeft(bool moveLeft)
    {
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
    }

    public void StopMoving()
    {
        moveLeft = moveRight = false;
        anim.SetBool("Walk", false);
    }

    void MoveLeft()
    {
        float forcex = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        if (vel < maxVelocity)
            forcex = -speed;
        anim.SetBool("Walk", true);

        Vector3 temp = transform.localScale;
        temp.x = -1.3f;
        transform.localScale = temp;
        myBody.AddForce(new Vector2(forcex, 0));
    }

    void MoveRight()
    {
        float forcex = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        if (vel < maxVelocity)
            forcex = speed;
        anim.SetBool("Walk", true);

        Vector3 temp = transform.localScale;
        temp.x = 1.3f;
        transform.localScale = temp;
        myBody.AddForce(new Vector2(forcex, 0));
    }

    private void Jump()
    {
        if (jumps > 0)
        {
            myBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumps = jumps - 1;
        }
        if (jumps == 0)
        {
            return;
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Cloud")
        {
            Debug.Log("Touching Cloud");
            jumps = maxJumps;
        }
    }
}
