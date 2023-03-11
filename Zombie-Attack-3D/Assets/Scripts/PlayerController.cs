using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;

    public string zombie;
    
    public float speed;
    
    public bool once;

    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {

        rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed*Time.deltaTime,rb.velocity.y,Input.GetAxis("Vertical") * speed * Time.deltaTime);

        if (GameObject.FindGameObjectsWithTag(zombie).Length>0)
        {
            GameObject[] zombies = GameObject.FindGameObjectsWithTag(zombie);

            GameObject closeZombie = zombies.OrderBy(obj => Vector3.Distance(transform.position, obj.GetComponent<Transform>().position)).FirstOrDefault();

            transform.LookAt(new Vector3(closeZombie.transform.position.x,1,closeZombie.transform.position.z));
        }
        


        
    }
}
