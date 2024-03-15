using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    /** SpawnManager
    /* Animal GameObjects Array to Spawn
    /* Range on the X-axis, where Animals can Spawn
    /* Default Z position, to hide spawn from camera
    */
    [SerializeField] private GameObject[] animalPrefabs;
    private float spawnRange = 20f;
    private float spawnPosZ = 20f;
    private float spawnStartDelay = 2f;
    private float spawnInterval = 1.5f;

    /**
    /* Start is called before the first frame update
    /* Repeatedly invoke SpawnRandomAnimal, wait for spawnStartDelay in sec and spawn every spawnInterval in sec.
    */
    void Start () {
        InvokeRepeating("SpawnRandomAnimal", spawnStartDelay, spawnInterval);
    }

    /** Update
    /* Update is called once per frame
    */
    void Update() {
    }

    /** SpawnRandomAnimal
    /* Get a random Spawnable Animal
    /* Get a random Spawn Position
    /* Spawn the chosen Animal on the chosen SpawnPosition
    */
     private void SpawnRandomAnimal () {
        int animalIndex = Random.Range(0, animalPrefabs.Length);                        
        Vector3 spawnPos = new(Random.Range(-spawnRange, spawnRange), 0, spawnPosZ);    
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);   
     }
}