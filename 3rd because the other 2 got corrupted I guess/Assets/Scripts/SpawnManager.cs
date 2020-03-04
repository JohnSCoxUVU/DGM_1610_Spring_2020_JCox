using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemyPrefabs;
    public int enemyIndex;
    public float time;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AutoSpawn());
    }

    IEnumerator AutoSpawn()
    {
        yield return new WaitForSeconds(time);
        Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);

        if (Input.GetKeyDown(KeyCode.Q)) 
        {
            Instantiate(enemyPrefabs[enemyIndex], new Vector3(0, 0, 0), enemyPrefabs[enemyIndex].transform.rotation);
        
        }


    }
}
