using UnityEditor;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyShip1;
    [SerializeField] GameObject EnemyShip2;
    [SerializeField] GameObject Meteor;
    [SerializeField] GameObject Meteorgroup;
    [SerializeField] GameObject PowerUp1;
    [SerializeField] GameObject PowerUp2;

    private float totalTime = 0;

    float timeSinceLastEnemy1 = 0;
    float timeSinceLastEnemy2 = 0;
    float timeSinceLastMeteor = 0;
    float timeSinceLastGroupMeteor = 0;
    float timeSinceLastPowerUp = 0;

    float enemy1Interval = 10;
    float enemy2Interval = 10;
    float meteorInterval = 8;
    float groupMeteorInterval = 14;
    float powerUpInterval = 45;

    float enemy1Health = 0f;
    float enemy2Health = 0f;
    float meteorHealth = 0f;
    float meteorGroupHealth = 0f;


    void Update()
    {
        totalTime += Time.deltaTime;

        timeSinceLastEnemy1 += Time.deltaTime;
        timeSinceLastEnemy2 += Time.deltaTime;
        timeSinceLastMeteor += Time.deltaTime;
        timeSinceLastGroupMeteor += Time.deltaTime;
        timeSinceLastPowerUp += Time.deltaTime;

        if (totalTime > 60)
        {
            enemy1Interval = 7;
            enemy2Interval = 7;
            meteorInterval = 5;
            groupMeteorInterval = 10;
        }

        if (totalTime > 105)
        {
            enemy1Interval = 5;
            enemy2Interval = 6;
            meteorInterval = 4;
            groupMeteorInterval = 7;

            enemy1Health = 2f;
            enemy2Health = 3f;
            meteorHealth = 2f;
            meteorGroupHealth = 1f;
        }

        if (totalTime > 165)
        {
            enemy1Interval = 4;
            enemy2Interval = 5;
            meteorInterval = 3;
            groupMeteorInterval = 6;

            enemy1Health = 3f;
            enemy2Health = 3f;
            meteorHealth = 3f;
            meteorGroupHealth = 2f;

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

        if (timeSinceLastPowerUp > powerUpInterval)
        {
            SpawnPowerUp();
        }
    }


    public void spawnEnemy1()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        GameObject enemy = Instantiate(EnemyShip1, randomPosition, Quaternion.identity);
        enemy.GetComponent<EnemyHealth>().health = enemy1Health;
        timeSinceLastEnemy1 = 0;
    }

    public void spawnEnemy2()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        GameObject enemy2 = Instantiate(EnemyShip2, randomPosition, Quaternion.identity);
        enemy2.GetComponent<EnemyHealth>().health = enemy2Health;
        timeSinceLastEnemy2 = 0;
    }

    public void MeteorSpawn()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        GameObject meteor = Instantiate(Meteor, randomPosition, Quaternion.identity);
        meteor.GetComponent<EnemyHealth>().health = meteorHealth;
        timeSinceLastMeteor = 0;
    }

    public void GroupMeteor()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18),
                                             11,
                                             0);
        GameObject group = Instantiate(Meteorgroup, randomPosition, Quaternion.identity);
        group.GetComponent<EnemyHealth>().health += meteorGroupHealth;
        timeSinceLastGroupMeteor = 0;
    }

    public void SpawnPowerUp()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-18, 18), 11, 0);
        GameObject selectedPowerUp;
        if (Random.value > 0.5f)
        {
            selectedPowerUp = PowerUp1;
        }
        else
        {
            selectedPowerUp = PowerUp2;
        }
        Instantiate(selectedPowerUp, randomPosition, Quaternion.identity);
        timeSinceLastPowerUp = 0;
    }
}