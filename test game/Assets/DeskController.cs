using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeskController : MonoBehaviour
{
    public Animator animator;
    public InventoryManager inventory;
    public BoxCollider2D collider2D;
    private bool contact = false;

    // Update is called once per frame
    void Update()
    {
        if (contact)
        {
            if (Input.GetKey("x"))
            {
                animator.SetBool("scTaken", true);
                inventory.GetScissors();
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            contact = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            contact = false;
        }
    }

}
