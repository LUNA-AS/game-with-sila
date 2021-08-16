using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleBox1 : MonoBehaviour
{
    public Vector3 puzzleXYZ;
    public CameraFollow mainCam;
    public string sceneName;
    private bool contact = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            contact = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            contact = false;
        }
    }
    private void Update()
    {
        if (contact) {
            if (Input.GetKeyDown("x")) {
                //SceneManager.LoadScene(sceneName);
                mainCam.MoveToPosition(puzzleXYZ);
                contact = false;
            }
        }
    }
}
