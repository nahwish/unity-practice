using System.Collections;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5.0f;
    private Rigidbody rb;
     public Animator anim;
     private bool isJumping = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        if ( Input.GetKeyDown( KeyCode.Space ) && !isJumping )
        {
            // toJump();
            anim.SetBool("jump", true);
            // actionJump();
        }  
        
    }
    
        void actionJump(){
            if(isJumping){
               rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                isJumping = false;
            }else{
                anim.SetBool("jump", false);
            }
        }

}




