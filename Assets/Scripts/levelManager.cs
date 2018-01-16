using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelManager : MonoBehaviour {

    public void loadLevel(string name)
    {
        Debug.Log("Level load requested for: " + name);
        Application.LoadLevel(name);
    }

    public void quitRequest()
    {
        Debug.Log("Quit request loaded");
        Application.Quit();
    }

}
