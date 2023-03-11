using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform player;

    public float speed,distance;
    

    
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(player.position.x,transform.position.y, player.position.z -distance), speed);
         
    }
}
