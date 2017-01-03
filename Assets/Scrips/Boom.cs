using UnityEngine;
using System.Collections;

public class Boom : MonoBehaviour
{
    public GameObject playerExplosion;

    void OnMouseUp() {
        Instantiate(playerExplosion, transform.position, transform.rotation);
        Destroy(gameObject.transform.parent.gameObject);
    }
}
