using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 10;
    [SerializeField] private float spawnPosZ = 12;
    [SerializeField] private float minSpawnDelay = 1f; // мин. задержка
    [SerializeField] private float maxSpawnDelay = 3f; // макс. задержка
    [SerializeField] private AudioSource spawnSound;

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));

            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

            if (spawnSound != null)
            {
                spawnSound.Play();
            }
        }
    }
}




//    void Start()
//    {
//        // Запуск корутины для спавна животных```
//        StartCoroutine(SpawnAnimals());
//    }

//    IEnumerator SpawnAnimals()
//    {
//        while (true) // Бесконечный цикл
//        {
//            // Рандомизация индекса
//            int animalIndex = Random.Range(0, animalPrefabs.Length);
//            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

//            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

//            // Ожидание перед следующим спавном
//            yield return new WaitForSeconds(spawnInterval);
//        }
//    }
//}