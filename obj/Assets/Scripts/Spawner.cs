using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyShip1;
    [SerializeField] GameObject EnemyShip2;
    [SerializeField] GameObject Meteor;
    [SerializeField] GameObject Meteorgroup;

    private float totalTime = 0;

    float timeSinceLastEnemy1 = 0;
    float timeSinceLastEnemy2 = 0;
    float timeSinceLastMeteor = 0;
    float timeSinceLastGroupMeteor = 0;

    float enemy1Interval = 10;
    float enemy2Interval = 10;
    float meteorInterval = 8;
    float groupMeteorInterval = 14;


    void Update()
    {
        totalTime += Time.deltaTime;

        timeSinceLastEnemy1 += Time.deltaTime;
        timeSinceLastEnemy2 += Time.deltaTime;
        timeSinceLastMeteor += Time.deltaTime;
        timeSinceLastGroupMeteor += Time.deltaTime;

        if (totalTime > 135)
        {
            enemy1Interval = 7;
            enemy2Interval = 7;
            meteorInterval = 5;
            groupMeteorInterval = 10;
        }

        if (timeSinceLastEnemy1 > enemy1Interval)
        {
            spawnEnemy1();
        }

        if (totalTime > 30 && timeSinceLastEnemy2 > enemy2Interval)
        {
            spawnEnemy2();
        }

        if (totalTime > 50 && timeSinceLastMeteor > meteorInterval)
        {
            MeteorSpawn();
        }

        if (totalTime > 80 && timeSinceLastGroupMeteor > groupMeteorInterval)
        {
            GroupMeteor();
        }
    }


    public void spawnEnemy1()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        Instantiate(EnemyShip1, randomPosition, Quaternion.identity);
        timeSinceLastEnemy1 = 0;
    }

    public void spawnEnemy2()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        Instantiate(EnemyShip2, randomPosition, Quaternion.identity);
        timeSinceLastEnemy2 = 0;
    }

    public void MeteorSpawn()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        Instantiate(Meteor, randomPosition, Quaternion.identity);
        timeSinceLastMeteor = 0;
    }

    public void GroupMeteor()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        Instantiate(Meteorgroup, randomPosition, Quaternion.identity);
        timeSinceLastGroupMeteor = 0;
    }
}