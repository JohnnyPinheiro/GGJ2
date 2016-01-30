using UnityEngine;
using System.Collections;

using UnityStandardAssets._2D;

public class Restart : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D coll)
    {
        
        if (coll.gameObject.tag == "Player")
        {
           // PlatformerCharacter2D char2D = coll.gameObject.GetComponent<PlatformerCharacter2D>();
            //char2D.loseLife();
            //char2D.gameObject.transform.position = Vector3.zero;
            Application.LoadLevel(Application.loadedLevel);
        }

        
    }
}
