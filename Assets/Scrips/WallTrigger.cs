using UnityEngine;
using System.Collections;

public class WallTrigger : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D col)
    {
       // print(col.gameObject.name);
        if (col.gameObject.CompareTag("magicBall")&& ! GameController._instance.gameOver) {
            GameController._instance.GetDamage();
        }
    
    }
}
