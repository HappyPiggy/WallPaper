using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

    private BoxCollider2D upWall;
    private BoxCollider2D leftWall;
    private BoxCollider2D rightWall;

    void Start()
    {
        ResetWall();
    }


    void ResetWall()
    {
        upWall = transform.Find("upWall").GetComponent<BoxCollider2D>();
        leftWall = transform.Find("leftWall").GetComponent<BoxCollider2D>();
        rightWall = transform.Find("rightWall").GetComponent<BoxCollider2D>();

        Vector3 upWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height));
        upWall.transform.position = upWallPosition + new Vector3(0, 0.5f, 0);
        float width = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x * 2;
        upWall.size = new Vector2(width, 1);


        Vector3 leftWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height / 2));
        leftWall.transform.position = leftWallPosition - new Vector3(0.5f, 0, 0);
        float height = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y * 2;
        leftWall.size = new Vector2(1, height);

        Vector3 rightWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height / 2));
        rightWall.transform.position = rightWallPosition + new Vector3(0.5f, 0, 0);
        rightWall.size = new Vector2(1, height);


    }
}
