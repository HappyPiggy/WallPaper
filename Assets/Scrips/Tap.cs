using UnityEngine;
using System.Collections;

public class Tap : MonoBehaviour {

    public float xSpeed;
    public float ySpeed;

    void OnMouseUp()
    {
        TapBall();
        if (!GameController._instance.gameOver) {

            //增加分数，生成别的球
            GameController._instance.AddScore(10);
            GameController._instance.SpawnOtherBalls();
        }

        PlaySound._instance.PlayTap();
    }


    void TapBall() {

        Vector2 velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
        float xVelocity1 = 0;
        float xVelocity2 = 0;
        float yVelocity = 0;

        yVelocity = Random.Range(5f * ySpeed , 10f * ySpeed);
       
        xVelocity1 = Random.Range(-10f * xSpeed, -5f * xSpeed);
        xVelocity2 = Random.Range(5f * xSpeed, 10f * xSpeed);

        if (Random.Range(0, 2) == 0)
            velocity.x = xVelocity1;
        else
            velocity.x = xVelocity2;

        velocity.y = yVelocity;

        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }


    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.tag == "Wall")
        {
            PlaySound._instance.PlayBump();
        }else if(col.collider.tag == "DownWall" && !GameController._instance.gameOver){
        
         PlaySound._instance.PlayDamage();
        }


    }
}
