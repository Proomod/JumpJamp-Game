using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private float movePlayer = 10f;

    [SerializeField]
    private float jumpForce = 10f;


    private float movementX;
    private float jumpingY;
    private Rigidbody2D myBody;
    private Animator animator;
    private SpriteRenderer sr;
    private string WALK_ANIMATION = "isWalking";

    private string JUMP_ANIMATION = "isJumping";


    private bool isGrounded;



    private void Awake()
    {

        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();


    }


    void Update()
    {
        PlayerKeyboardMovement();
        AnimatePlayer();
        jumping();


    }

    private void AnimatePlayer()
    {
        animator.SetBool(WALK_ANIMATION, false);

        if (movementX == 1 || movementX == -1)
            animator.SetBool(WALK_ANIMATION, true);
        animator.SetBool(JUMP_ANIMATION, false);




    }
    private void PlayerKeyboardMovement()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * movePlayer;

        if (movementX == -1)
            sr.flipX = true;
        else
            sr.flipX = false;



    }
    void FixedUpdate()
    {

    }
    private void jumping()
    {


        // Debug.Log(Input.GetButtonUp("Jump"));
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            animator.SetBool(JUMP_ANIMATION, true);

            myBody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }

    }


}
