using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Canvas canvas;

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


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="Upgrade")
        {
            canvas.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Upgrade")
        {
            canvas.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
