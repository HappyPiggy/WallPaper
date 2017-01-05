using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerSpawner : MonoBehaviour {

    public GameObject mainBall;
    public GameObject[] playerList;
    public Transform startPos;


    private List<GameObject> allObj;
    

    public static PlayerSpawner _instance;

    void Awake()
    {
        _instance = this;
    }

    void Start() { 
    
        allObj=new List<GameObject>();
    }


    public void OnStartClick() {

        GameController._instance.playerSpawner.SetActive(false);
        GameController._instance.InitGame();

        //生成主角球
        GameObject mainPlayer = Instantiate(mainBall, startPos.position, startPos.rotation) as GameObject;
        allObj.Add(mainPlayer);
     
    }



    //主角球被点击时生成其他球
    public  void Spawn() {

        if (playerList == null || playerList.Length == 0 )
            return;

        Vector3 spawnPos1 = new Vector3(-8f, -3.4f, 0);
        Vector3 spawnPos2 = new Vector3(8f, -3.4f, 0);

        Quaternion rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));

        int index = Random.Range(0, playerList.Length);
        //print(index);

        if (Random.Range(0, 2) == 1)
            spawnPos1 = spawnPos2;
        GameObject playerClone = Instantiate(playerList[index], spawnPos1, rotation) as GameObject;

        if (spawnPos1 == spawnPos2)
        {
            playerClone.transform.FindChild("image").GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-1f, -5f), Random.Range(5f, 15f));
        }
        else {
            playerClone.transform.FindChild("image").GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(1f, 5f), Random.Range(5f, 15f));
        }
        
        allObj.Add(playerClone);

    }

    public void DestroyAllObj() {

        if (allObj == null || allObj.Count == 0)
            return;
        for (int i = 0; i < allObj.Count; i++) {
           // print(allObj[i]);
            Destroy(allObj[i]);
        }
    
    
    }
}
