using UnityEngine;
using System.Collections;

public class PlayerSpawner : MonoBehaviour {

    public GameObject[] playerList;


    public void PlayerSpawn() {

        if (playerList == null || playerList.Length == 0)
            return;

        Vector3 spawnPos = new Vector3(Random.Range(-5f,5f),3,0);
       // print(spawnPos);
        Quaternion rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));

        int index = Random.Range(0, playerList.Length);
        GameObject playerClone = Instantiate(playerList[index], spawnPos, rotation) as GameObject;
    }
}
