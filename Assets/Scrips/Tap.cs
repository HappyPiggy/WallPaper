using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour {

    void OnMouseUp()
    {
        TapBall();
        GameController._instance.AddScore(5);   

    }


    void TapBall() {

        Vector2 velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
        float xVelocity = 0;
        float yVelocity = 0;
        yVelocity = Random.Range(5f, 10f);
        xVelocity = Random.Range(-10f, 10f);

        velocity.x = xVelocity;
        velocity.y = yVelocity;

        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
