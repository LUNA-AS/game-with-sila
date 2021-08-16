using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleBoxController : MonoBehaviour
{
    public Text in1, in2, in3, in4, in5;
    public Animator animator;
    public InventoryManager inventory;
    public string passowrd;
    private string currentWord;
    private bool solved = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentWord = in1.text + in2.text + in3.text + in4.text + in5.text;
        if (currentWord == passowrd) {
            animator.SetBool("isOpen", true);
            solved = true;
        }
        if (Input.GetKey("x")) {
            takeKey();
        }
    }
    private void takeKey() {
        if (solved) {
            inventory.GetKey();
            animator.SetBool("keyTaken", true);
        }
    }
}
