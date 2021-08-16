using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float distance;

    // Start is called before the first frame update
    public void MoveToPosition(Vector3 XYZ) {
        transform.position = XYZ;
    }
    public void BackToStart() {
        transform.position = new Vector3(0,0,-10);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x - player.position.x)> distance) {
            if (transform.position.x - player.position.x > 0) {
                
                transform.position = new Vector3(transform.position.x - offset.x,  offset.y, offset.z);
            }
            else {
                transform.position = new Vector3(transform.position.x + offset.x,  offset.y, offset.z);
            }
            
        }
        
    }
}
