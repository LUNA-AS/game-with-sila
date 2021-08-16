using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class CharMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Animator animator;

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    private bool isJump = false;

    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        // get input from the player
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("Jump", true);
            isJump = true;
        }
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed ;
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Coin")) {
            Destroy(other.gameObject);
            
        }
    }

    void FixedUpdate(){
        // move the character here
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, isJump);
        isJump = false;
        
    }

     void OnLanding() {
        animator.SetBool("Jump", false);
    }
}


