using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Jugador : MonoBehaviour
{
    public float runSpeed = 4;
    public float jumpSpeed = 6;
    public Rigidbody2D rb2D;
    public bool betterJump = false;
    public float fallMultiplier = 0.5f;
    public float lowJumpMultiplier = 1f;
    public SpriteRenderer spriteRenderer;

    public Animator animator;


    public AudioSource AudioJump;
   // public GameObject Panel;
    void Start()
    {
        rb2D  = GetComponent<Rigidbody2D>();
    } 

    void FixedUpdate(){
        

        if(Input.GetKey("d") || Input.GetKey("right") ){
            rb2D.velocity = new Vector2(runSpeed,rb2D.velocity.y);
            spriteRenderer.flipX=false;
            animator.SetBool("Run",true);
            
            
            
        }else if(Input.GetKey("a") || Input.GetKey("left")){
            rb2D.velocity = new Vector2(-runSpeed,rb2D.velocity.y);
            spriteRenderer.flipX=true;
            animator.SetBool("Run",true);

            //AudioJump.Play();
        }else{
            rb2D.velocity = new Vector2(0,rb2D.velocity.y);
            animator.SetBool("Run",false);
        }
        if(Input.GetKey("space") && CheckGround.isGrounded){
            rb2D.velocity = new Vector2(rb2D.velocity.x, jumpSpeed);
        AudioJump.Play();
        }

        if(CheckGround.isGrounded==false){
            animator.SetBool("Jump",true);
            animator.SetBool("Run",false);
        }
        if(CheckGround.isGrounded==true){
            animator.SetBool("Jump",false);
        }

        if(betterJump){
                if(rb2D.velocity.y<0){
                    rb2D.velocity += Vector2.up * Physics2D.gravity.y*(fallMultiplier)* Time.deltaTime;
                }
                if(rb2D.velocity.y>0 && !Input.GetKey("space")){
                    rb2D.velocity += Vector2.up * Physics2D.gravity.y*(lowJumpMultiplier)* Time.deltaTime;
                }
            }
        
    }
 public void OnCollisionExit2D(Collision2D collision){
        if(collision.gameObject.tag == "CalendarioMaya"){
            Debug.Log("Encontro un Objeto");
           // Panel.SetActive(true);
        }
        
    }
    

}
