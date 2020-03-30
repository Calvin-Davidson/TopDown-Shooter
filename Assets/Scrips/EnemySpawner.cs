using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<Vector3> locations;
    [SerializeField] private GameObject[] Enemies;
    [SerializeField] private bool userSpawnPoints;

    private void Awake()
    {
        if (userSpawnPoints)
        {
            locations.Clear();
            foreach(Transform t in GameObject.Find("EnemySpawnpoints").GetComponentsInChildren<Transform>())
            {
                locations.Add(t.position);
            }
            locations.Remove(GameObject.Find("EnemySpawnpoints").transform.position);
            Debug.Log("C: " + locations.Count);
        }
    }



    private void Start()
    {
            StartCoroutine(StartSpawning());
    } 

    private IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(5);

        StartCoroutine(StartSpawning());

        Vector3 spawnloc = locations[Random.Range(0, locations.Count)];

        GameObject spawned = Instantiate(Enemies[Random.Range(0, Enemies.Length)], spawnloc, Quaternion.identity);
    }
}


