using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanGround : MonoBehaviour {

    public bool enableSpawn = true;
    public GameObject ground;
   
    void SpawnGround()
    {
         if (enableSpawn)
        {
                  
            GameObject ground1 = Instantiate(ground, new Vector3(Random.Range(-10f, 10f), -3.0f, -1.0f), Quaternion.identity);
            GameObject ground2 = Instantiate(ground, new Vector3(Random.Range(-10f, 10f), -3.0f, -1.0f), Quaternion.identity);
            GameObject ground3 = Instantiate(ground, new Vector3(Random.Range(-10f, 10f), -3.0f, -1.0f), Quaternion.identity);

        }
    }
    void Start()
    {
        SpawnGround();
    }
    void Update()
    {

    }
}
