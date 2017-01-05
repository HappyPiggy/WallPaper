using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {


    public int maxHealth = 3;
    public Text scoreText;
    public GameObject[] hearts;

    public Image damageImage;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);
    public float flashSpeed = 5f;  

    private BoxCollider2D upWall;
    private BoxCollider2D leftWall;
    private BoxCollider2D rightWall;
    private BoxCollider2D downWall;

    private BoxCollider2D basket;
    private int currentHealth;
    private int score;
    private bool damaged;

    [HideInInspector]
    public bool gameOver;
    [HideInInspector]
    public GameObject playerSpawner;


    public static GameController _instance;

    void Awake()
    {
        _instance = this;
        playerSpawner = GameObject.Find("PlayerSpawner").gameObject;
        playerSpawner.SetActive(true);
    }

    void Start()
    {
        ResetWall();
       // InitGame();

    }

    void Update()
    {
        // If the player has just been damaged...
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }

        // Reset the damaged flag.
        damaged = false;
    }


    public void SpawnOtherBalls() {

        PlayerSpawner._instance.Spawn();
    }

   public void InitGame() {

        currentHealth = maxHealth;
        score = 0;
        gameOver = false;
        damaged = false;
        UpdateScore();
        PlayerSpawner._instance.DestroyAllObj();

        for (int i = 0; i < hearts.Length; i++) {
            hearts[i].SetActive(true);
        }
    
    }

    public void GetDamage() {

        damaged = true;
        currentHealth -= 1;
           

        switch (currentHealth) { 
            case 0:
                //游戏结束
                hearts[0].SetActive(false);
                playerSpawner.SetActive(true);
                gameOver = true;
                break;
            case 1:
                hearts[1].SetActive(false);
                break;
            case 2:
                hearts[2].SetActive(false);
                break;
        }
    }

    public void AddScore(int bonus) {
        score += bonus;
        UpdateScore();
    }


    void UpdateScore() {
        scoreText.text = "Score:"+score;
    
    }





    void ResetWall()
    {
        upWall = transform.Find("upWall").GetComponent<BoxCollider2D>();
        leftWall = transform.Find("leftWall").GetComponent<BoxCollider2D>();
        rightWall = transform.Find("rightWall").GetComponent<BoxCollider2D>();
        downWall = transform.Find("downWall").GetComponent<BoxCollider2D>();




        Vector3 upWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, Screen.height));
        upWall.transform.position = upWallPosition + new Vector3(0, 0.5f, 0);
        float width = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x * 2;
        upWall.size = new Vector2(width, 1);

        Vector3 downWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width / 2, 0));
        downWall.transform.position = downWallPosition;
        downWall.size = new Vector2(width, 1);


        Vector3 leftWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height / 2));
        leftWall.transform.position = leftWallPosition - new Vector3(0.5f, 0, 0);
        float height = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y * 2;
        leftWall.size = new Vector2(1, height);

        Vector3 rightWallPosition = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height / 2));
        rightWall.transform.position = rightWallPosition + new Vector3(0.5f, 0, 0);
        rightWall.size = new Vector2(1, height);


    }
}
