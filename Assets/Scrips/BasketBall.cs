using UnityEngine;
using System.Collections;

public class BasketBall : MonoBehaviour {


    public float speed;

    void OnMouseUp()
    {
      //  print(Vector2.down * speed);
        PlaySound._instance.PlayBasketball();
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);

    }



}
