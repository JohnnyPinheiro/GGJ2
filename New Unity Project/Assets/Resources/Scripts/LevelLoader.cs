using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if( player == null)
        {
            player = Resources.Load("Character2") as GameObject;
            Instantiate<GameObject>(player);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
