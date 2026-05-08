using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject EnemyShip1;
    [SerializeField] GameObject Meteor;
    private float timer = 0;
    private float totalTime = 0;
    float timesincelastspawned = 0;
    private float spawnInterval = 8;
    float timebetweenspawns = 2;


    void Update()
    {
        timer += Time.deltaTime;
        totalTime += Time.deltaTime;
        timesincelastspawned += Time.deltaTime;

        if (timesincelastspawned > timebetweenspawns)
        {
            spawnEnemy1();
        }

        if (timer >= spawnInterval)
        {
            MeteorSpawn();
            timer = 0f;
        }
    }


    public void spawnEnemy1()
    {
        if (totalTime < 30)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-18, 18), // x
                                                 Random.Range(11, 11), // y
                                                 0);
            transform.Rotate(0, 0, -180);
            Instantiate(EnemyShip1, randomPosition, Quaternion.identity);

            timesincelastspawned = 0;
        }
        else if (totalTime > 30)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-18, 18), // x
                                                 Random.Range(11, 11), // y
                                                 0);
            transform.Rotate(0, 0, -180);
            Instantiate(EnemyShip1, randomPosition, Quaternion.identity);
            timebetweenspawns = 1;
            timesincelastspawned = 0;
        }
    }

    public void MeteorSpawn()
    {
        if (totalTime < 20)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-18, 18), // x
                                                 Random.Range(11, 11), // y
                                                 0);
            Instantiate(Meteor, randomPosition, Quaternion.identity);
        }
        else if (totalTime > 20 && totalTime < 40)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-18, 18), // x
                                                 Random.Range(11, 11), // y
                                                 0);
            Instantiate(Meteor, randomPosition, Quaternion.identity);

            spawnInterval = 6;

        }
        else if (totalTime > 50)
        {
            Vector3 randomPosition = new Vector3(Random.Range(-18, 18), // x
                                                 Random.Range(11, 11), // y
                                                 0);
            Instantiate(Meteor, randomPosition, Quaternion.identity);

            spawnInterval = 3;

        }
    }
}
