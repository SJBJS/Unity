using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanGround : MonoBehaviour {

    public bool enableSpawn = true;
    public GameObject ground;
   

    void Start()
    {
        GameObject ground1 = Instantiate(ground, new Vector3(-9.0f, -4.0f, -1.0f), Quaternion.identity);

        SpawnGround();

    }
    void Update()
    {

    }

    void SpawnGround()
    {
        if (enableSpawn)
        {
            GameObject ground1 = Instantiate(ground, new Vector3(Random.Range( -6f, 10f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground2 = Instantiate(ground, new Vector3(Random.Range( -6f, 10f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground3 = Instantiate(ground, new Vector3(Random.Range( -6f, 10f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground4 = Instantiate(ground, new Vector3(Random.Range( 10f, 25f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground5 = Instantiate(ground, new Vector3(Random.Range( 10f, 25f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground6 = Instantiate(ground, new Vector3(Random.Range( 10f, 25f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground7 = Instantiate(ground, new Vector3(Random.Range( 25f, 40f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground8 = Instantiate(ground, new Vector3(Random.Range( 25f, 40f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground9 = Instantiate(ground, new Vector3(Random.Range( 25f, 40f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground10 = Instantiate(ground, new Vector3(Random.Range(40f, 55f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground11 = Instantiate(ground, new Vector3(Random.Range(40f, 55f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground12 = Instantiate(ground, new Vector3(Random.Range(40f, 55f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground13 = Instantiate(ground, new Vector3(Random.Range(55f, 70f), -4.0f, -1.0f), Quaternion.identity);
            GameObject ground14 = Instantiate(ground, new Vector3(Random.Range(55f, 70f), -4.0f, -1.0f), Quaternion.identity);

            GameObject ground20 = Instantiate(ground, new Vector3(Random.Range(-6f, 10f),    0f, -1.0f), Quaternion.identity);
            GameObject ground21 = Instantiate(ground, new Vector3(Random.Range(-6f, 10f),    0f, -1.0f), Quaternion.identity);
            GameObject ground22 = Instantiate(ground, new Vector3(Random.Range(-6f, 10f),    0f, -1.0f), Quaternion.identity);
            GameObject ground23 = Instantiate(ground, new Vector3(Random.Range(10f, 25f),    0f, -1.0f), Quaternion.identity);
            GameObject ground24 = Instantiate(ground, new Vector3(Random.Range(10f, 25f),    0f, -1.0f), Quaternion.identity);
            GameObject ground25 = Instantiate(ground, new Vector3(Random.Range(10f, 25f),    0f, -1.0f), Quaternion.identity);

        }
    }
}
