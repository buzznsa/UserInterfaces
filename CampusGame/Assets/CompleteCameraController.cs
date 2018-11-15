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
     
        y = 12.17f;
        x = 15.9f;
        z = 14.8f;
    }

    void FixedUpdate()
    {
       
       
        transform.position = new Vector3(target.position.x + offset.x, offset.y, target.position.z + offset.z);
   
    }

}

