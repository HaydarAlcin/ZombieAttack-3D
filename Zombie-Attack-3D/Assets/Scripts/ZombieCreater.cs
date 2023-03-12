using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieCreater : MonoBehaviour
{
    public GameObject zombie;

    public bool oneTime;
    void Start()
    {
        oneTime = true;
    }

    
    void Update()
    {
        ZombieCreate();
    }



    public void ZombieCreate()
    {
        if (oneTime==true)
        {
            oneTime = false;
            for (int i = 0; i < 10; i++)
            {
                Instantiate(zombie, transform.position, Quaternion.identity);
            }
        }
        
    }
}
