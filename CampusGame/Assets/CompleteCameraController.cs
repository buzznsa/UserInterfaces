using UnityEngine;
using System.Collections;

public class CompleteCameraController : MonoBehaviour
{

    public Transform target;
    public float smoothing = 5f;
    Vector3 offset = new Vector3(13f, 12.3f, -14f);
    float y;
    float x;
    float z;
    void Start()
    {
        //offset = transform.position - target.position;
        Debug.Log(target.position.x);
        Debug.Log(target.position.y);
        Debug.Log(offset.x);
        Debug.Log(offset.y);
        y = 12.17f;
        x = 15.9f;
        z = 14.8f;
    }

    void FixedUpdate()
    {
       
        Debug.Log(target.position.x);
        Debug.Log(target.position.y);
        Debug.Log(offset.x);
        Debug.Log(offset.y);
        transform.position = new Vector3(target.position.x + offset.x, offset.y, target.position.z + offset.z);
        Debug.Log(target.position.x + offset.x);
        Debug.Log(target.position.y + offset.y);
    }

}

