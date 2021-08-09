using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody2D rb2D;
    public float speed;
    public float jumpForce;
    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public Transform CharacterScale;
    public AudioSource JumpingAudio;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    void LateUpdate()
    {
        Move();
        Jump();
        CheckifGrounded();
        
       
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb2D.velocity = new Vector2(moveBy, rb2D.velocity.y);
        Vector2 CharacterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            CharacterScale.x = -1;
        }
        if(Input.GetAxis("Horizontal") > 0)
        {
            CharacterScale.x = 1;
        }

        transform.localScale = CharacterScale;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            JumpingAudio.Play();
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
        }
    }

    void CheckifGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);

        if(collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }


}
