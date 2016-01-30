using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
    public Vector2 startPosition;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if( player == null)
        {
            player = Resources.Load("Prefabs/Character") as GameObject;
            Instantiate<GameObject>(player);
        }

        player.transform.position = new Vector3(startPosition.x, startPosition.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
