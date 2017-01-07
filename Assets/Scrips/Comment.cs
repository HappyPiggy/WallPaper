using UnityEngine;
using System.Collections;

public class Comment : MonoBehaviour {

    public GameObject[] comments;
    public float lastTime=1.5f;

    private int index;
    private bool isSaying = false;

    private Vector3 largeScale;
    private Vector3 normalScale;

    private Vector3 _vec3TargetScreenSpace;// 目标物体的屏幕空间坐标  
    private Vector3 _vec3TargetWorldSpace;// 目标物体的世界空间坐标  
    private Transform _trans;// 目标物体的空间变换组件  
    private Vector3 _vec3MouseScreenSpace;// 鼠标的屏幕空间坐标  
    private Vector3 _vec3Offset;// 偏移  


    void Start() {

        largeScale = new Vector3(2, 2, 2);
        normalScale = new Vector3(1, 1, 1);
    
    }

    void OnMouseUp()
    {



        if (!isSaying) {

            if (gameObject.CompareTag("angry"))
            {
                gameObject.transform.localScale = largeScale;
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
