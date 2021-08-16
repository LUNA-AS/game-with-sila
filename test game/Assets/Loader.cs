using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public static class Loader 
{
    public enum scene { 
        SampleScene,
        Box_puzzle
    }
    public static void Load(string name) {
        SceneManager.LoadScene(name);
    }
}
