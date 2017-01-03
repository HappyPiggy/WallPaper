using UnityEngine;
using System.Collections;

public class Fly : MonoBehaviour {

   // public float startTime;
  //  public float waitTime;

  //  public float yVelocity;

    //void Start () {
    //    StartCoroutine(AutoRun()); 
    //}




    //IEnumerator AutoRun()
    //{

    //    yield return new WaitForSeconds(startTime);
    //    while (true)
    //    {

    //        Vector2 velocity= gameObject.GetComponent<Rigidbody2D>().velocity;
    //        float xVelocity=0;
    //        float yVelocity = 0;
    //        if (gameObject.CompareTag("rocket"))
    //        {
    //             yVelocity = Random.Range(5f, 12f);
    //             xVelocity = Random.Range(-5f, 5f);
    //        }
    //        else {
    //             yVelocity = Random.Range(-8f, 8f);
    //             xVelocity = Random.Range(-5f, 5f);
    //        }


    //        velocity.x = xVelocity;
    //        velocity.y = yVelocity;

    //        gameObject.GetComponent<Rigidbody2D>().velocity =velocity;

    //        yield return new WaitForSeconds(waitTime);
    //    }



    //}


    void OnMouseUp()
    {

        Vector2 velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
        float xVelocity = 0;
        float yVelocity = 0;
        yVelocity = Random.Range(5f, 12f);
        xVelocity = Random.Range(-5f, 5f);

        velocity.x = xVelocity;
        velocity.y = yVelocity;

        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
    }
}
