using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animalPrefabs;   // Animal GameObjects Array to Spawn
    private float spawnRange = 20f;                         // Range on the X-axis, where Animals can Spawn
    private float spawnPosZ = 20f;                          // Default Z position, to hide spawn from camera
    void Update()
    {    // Update is called once per frame
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);                        // Get a random Spawnable Animal 
            Vector3 spawnPos = new(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);    // Get a random Spawn Position
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);   // Spawn the chosen Animal on the chosen SpawnPosition
        }
    }
}