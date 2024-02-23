using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectPrefab;

    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private int randomRange;

    // Start is called before the first frame update
    void Start()
    {
        randomRange = Random.Range(1, 4);
        InvokeRepeating("SpawnObstacle", 2, randomRange);
        //Instantiate(objectPrefab, spawnPos, objectPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle(){
        //Blippdulpoop
        Instantiate(objectPrefab, spawnPos, objectPrefab.transform.rotation);
        randomRange = Random.Range(1, 4);

    }
}
