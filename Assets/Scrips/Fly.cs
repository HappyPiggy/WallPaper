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

    private bool isFly = false;

    void OnMouseUp()
    {
        isFly = true;
        Invoke("TakeDown",1.5f);

      //  Vector2 velocity = gameObject.GetComponent<Rigidbody2D>().velocity;
      //  float xVelocity = 0;
      //  float yVelocity = 0;
      //  yVelocity = Random.Range(10f, 15f);
      //  xVelocity = Random.Range(-5f, 5f);

      //  velocity.x = xVelocity;
      //  velocity.y = yVelocity;

    }

    void Update() { 

        if(isFly){
            float v = Random.Range(1f,10f);
           // gameObject.GetComponent<Rigidbody2D>().velocity = velocity;
           // gameObject.transform.Translate(Vector3.up * v  * Time.deltaTime);
            Vector3 newPos = transform.up * v ;
            gameObject.GetComponent<Rigidbody2D>().MovePosition(Vector2.Lerp(transform.position, transform.position + newPos,  Time.deltaTime));
        
        }
    }


    void TakeDown() {
        isFly = false;
    }
}
