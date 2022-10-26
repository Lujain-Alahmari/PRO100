using UnityEngine;

public class pipespawn : MonoBehaviour
{
    [SerializeField] GameObject bottompipePrefab;
    [SerializeField] GameObject toppipePrefab;
    [SerializeField] Transform spawnpoint;

    GameObject currentPipe;
    float currentSpawnTime;
    float SpawnHeight;

    // Update is called once per frame
    void Update()
    {
        spawnpipe();
    }
    void spawnpipe()
    {
        if (Time.time > currentSpawnTime)
        {
            Debug.Log("spawn pipe!");

            spawnHeight();

            PipeDirection();

            Instantiate(currentPipe, new Vector3(spawnpoint.position.x, SpawnHeight, spawnpoint.position.z), Quaternion.identity, transform);

            currentSpawnTime = Time.time + 2;
        }
    }
    void spawnHeight()
    {
        SpawnHeight = Random.Range(-2.0f, 4.0f);
    }

    void PipeDirection()
    {
        int directionIndex = Random.Range(0, 2);

        if (directionIndex == 0)
        {
            currentPipe = bottompipePrefab;
        }
        else
        {
            currentPipe = toppipePrefab;
        }
    }

}