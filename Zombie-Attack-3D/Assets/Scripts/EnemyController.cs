using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;

    public float enemySpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
    }


    public void Move()
    {
        
        rb.velocity = transform.forward * enemySpeed * Time.deltaTime;
        transform.LookAt(new Vector3(player.transform.position.x, 1, player.transform.position.z));
    }
}
