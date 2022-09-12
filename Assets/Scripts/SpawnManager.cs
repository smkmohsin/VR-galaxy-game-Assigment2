using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public GameObject[] meteorPrefab;
    public GameObject meteorPrefab, meteorSpawner;
    public float meteorBurstCount = 5, spawnInterval = 2f;

    private float spawnRangeX = 5;
    private float spawnRangeY = 2;
    float updateTime;
    // Start is called before the first frame update
    void Start()
    {
    
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Time.time > updateTime)
        {
            updateTime = Time.time + spawnInterval;
            SpawnMeteorRandom();
        }
        
    }

    void SpawnMeteorRandom()
    {
        if(meteorSpawner.transform.childCount < meteorBurstCount)
        {
             // Ramdomly generate meteor spawn position
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), 20);

            // Ramdomly generate meteor index
            //int meteorIndex = Random.Range(0, meteorPrefab.Length);

            // Spawning meteor
            /**var meteorInstance = Instantiate(meteorPrefab[meteorIndex], spawnPos ,meteorPrefab[meteorIndex].transform.rotation);**/
            var meteorInstance = Instantiate(meteorPrefab, spawnPos ,meteorPrefab.transform.rotation);
            
            meteorInstance.transform.SetParent(meteorSpawner.transform);
        }
       
    }
    
}
