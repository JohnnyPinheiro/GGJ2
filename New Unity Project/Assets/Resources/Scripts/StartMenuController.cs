using UnityEngine;
using System.Collections;

public class StartMenuController : MonoBehaviour {
    private bool paused = false;
    private bool pausePressed = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if( Input.GetKey(KeyCode.P) && !paused && !pausePressed)
        {
            paused = true;
            pausePressed = true;
        } else if (Input.GetKey(KeyCode.P) && !pausePressed ) {
            paused = false;
            pausePressed = true;
        } else if (!Input.GetKey(KeyCode.P) && pausePressed){
            pausePressed = false;
        }

    }

    void OnGUI()
    {
        if (paused)
        {
            GUI.Label(new Rect(100, 100, 100, 20), "continue");
            GUI.Label(new Rect(100, 100, 100, 20), "Return to the Menu");
        }
    }
}
