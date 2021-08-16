using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectableObject : MonoBehaviour
{
    public GameObject largeImg;
    public GameObject textHolder;
    private bool contact = false;
    // Start is called before the first frame update
    void Start()
    {
        largeImg.SetActive(false);
        textHolder.SetActive(false);
    }
    private void Update()
    {
        if (contact) {
            if (Input.GetKey("x"))
            {
                largeImg.SetActive(true);
            }
            else if (!Input.GetKey("x"))
            {
                largeImg.SetActive(false);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            contact = true;
            textHolder.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            contact = false;
            largeImg.SetActive(false);
            textHolder.SetActive(false);
        }
    }
}
