using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
    private float horizontalMove=0f;
    private float verticalMove=0f;
    public Joystick joystick;
    public float runSpeedHorizontal = 4;
    public float runSpeed = 1.25f;
    public float jumpSpeed = 6;
    public Rigidbody2D rb2D;
    
    public SpriteRenderer spriteRenderer;

    public Animator animator;

   // public GameObject Panel;
    void Start()
    {
        rb2D  = GetComponent<Rigidbody2D>();
    } 

    private void Update()
    {
        if(horizontalMove>0){
            spriteRenderer.flipX=false;
            animator.SetBool("Run",true);
            
        }else if(horizontalMove<0){
            spriteRenderer.flipX=true;
            animator.SetBool("Run",true);
        }else{
            animator.SetBool("Run",false);
        }
        /*
        if(Input.GetKey("space") && CheckGround.isGrounded){
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        
        }*/

        if(CheckGround.isGrounded==false){
            animator.SetBool("Jump",true);
            animator.SetBool("Run",false);
        }
        if(CheckGround.isGrounded==true){
            animator.SetBool("Jump",false);
        }
    }
    void FixedUpdate(){

        horizontalMove = joystick.Horizontal * runSpeedHorizontal;
        transform.position+=new Vector3(horizontalMove,0,0) * Time.deltaTime * runSpeed;

        
        /*
        if(betterJump){
                if(rb2D.velocity.y<0){
                    rb2D.velocity += Vector2.up * Physics2D.gravity.y*(fallMultiplier)* Time.deltaTime;
                }
                if(rb2D.velocity.y>0 && !Input.GetKey("space")){
                    rb2D.velocity += Vector2.up * Physics2D.gravity.y*(lowJumpMultiplier)* Time.deltaTime;
                }
            }
        */
    }
 public void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag == "CalendarioMaya"){
            Debug.Log("Encontro un Objeto");
           // Panel.SetActive(true);
        }
    }

    public void Jump()
    {
        if(CheckGround.isGrounded)
        {
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        }
    }
}
