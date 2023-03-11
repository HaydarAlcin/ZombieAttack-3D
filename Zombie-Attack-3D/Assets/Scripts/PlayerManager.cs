using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Transform gun;
    public GameObject Bullet;

    public float time;
    void Start()
    {
    }

    
    void Update()
    {
        Fire();
    }

    
    public void Fire()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;


        }
        else if (time <= 0)
        {
            time = 0.5f;

            //LookRotation ile oyuncunun baktigi yeri referans alip bullet degiskenini cevirdik
            Instantiate(Bullet, gun.position, Quaternion.LookRotation(Bullet.transform.forward,transform.forward));
            
        }
            
    }
}
