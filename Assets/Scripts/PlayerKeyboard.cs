using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKeyboard : MonoBehaviour
{
    public float speed = 8f;
    public float maxVelocity = 4f;

    public int maxJumps = 1;
    private int jumps;
    private float jumpForce = 2f;

    //[SerializeField]
    private Rigidbody2D myBody;
    private Animator anim;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMoveKeyboard();

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            this.Jump();
        }
    }

    void PlayerMoveKeyboard()
    {
        float forcex = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal"); // -1 0 1

        if (h > 0)
        {
            if (vel < maxVelocity)
                forcex = speed;
            anim.SetBool("Walk",true);

            Vector3 temp = transform.localScale;
            temp.x = 1.3f;
            transform.localScale = temp;
        }else if (h < 0)
        {
            if (vel < maxVelocity)
                forcex = -speed;
            anim.SetBool("Walk", true);

            Vector3 temp = transform.localScale;
            temp.x = -1.3f;
            transform.localScale = temp;
        }
        else
        {
            anim.SetBool("Walk", false);
        }

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
