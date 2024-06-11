using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Transform spawnPoint;
    public float spawnIntervak = 5f;

    IEnumerator spawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPoint.position, spawnPoint.rotation);

        yield return new WaitForSeconds(spawnIntervak);
    }


    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collision collision)
        {
            spawnObstacle();
        }

        
    }
}
