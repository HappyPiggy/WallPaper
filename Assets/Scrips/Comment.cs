using UnityEngine;
using System.Collections;

public class Comment : MonoBehaviour {

    public GameObject[] comments;
    public float lastTime=1.5f;

    private int index;
    private bool isSaying = false;

    private Vector3 largeScale;
    private Vector3 normalScale;


    void Start() {

        largeScale = new Vector3(2, 2, 2);
        normalScale = new Vector3(1, 1, 1);
    
    }

    void OnMouseUp()
    {



        if (!isSaying) {


            if (transform.CompareTag("angry"))
            {
                gameObject.transform.localScale = largeScale;
                PlaySound._instance.PlayAngry();
            }
            else {
                PlaySound._instance.PlayFunny();
            }
            
            index = Random.Range(0, comments.Length);
            comments[index].SetActive(true);
            Invoke("ActiveFalse", lastTime);
            isSaying = true;
        }
     
    }





    void ActiveFalse() {
        comments[index].SetActive(false);
        isSaying = false;
        if (gameObject.CompareTag("angry"))
        {
            gameObject.transform.localScale = normalScale;
        }

    }
}
