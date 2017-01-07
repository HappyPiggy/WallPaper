using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour {

    void OnMouseUp()
    {
        TapBall();
        if (!GameController._instance.gameOver) {

            //增加分数，生成别的球
            GameController._instance.AddScore(10);

            GameController._instance.SpawnOtherBalls();

            PlaySound._instance.PlayTap();
        }
             

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


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Wall")
        {
            PlaySound._instance.PlayBump();
        }


    }
}
