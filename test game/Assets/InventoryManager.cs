using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private bool key, plant, scissors = false;
    // Start is called before the first frame update
    public void GetKey()
    {
        key = true;
    }
    public void GetScissors()
    {
        scissors = true;
    }
}
