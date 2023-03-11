using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    public float speed;

    
    void Update()
    {
        transform.Translate(transform.forward*speed*Time.deltaTime);

        Destroy(this.gameObject,2f);
    }
}
