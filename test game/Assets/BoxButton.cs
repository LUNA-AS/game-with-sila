using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BoxButton : MonoBehaviour
{
    private void Start()
    {
        text.text = letters[currentIndex];
    }

    public Text text;
    private string[] letters = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
    "N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
    public int currentIndex = 0;

    public void UpdateLetter() {
        if (currentIndex == 25) {
            currentIndex = 0;
            text.text = letters[currentIndex];
        }
        else {
            currentIndex ++;
            text.text = letters[currentIndex];
        }
    }
    
}
