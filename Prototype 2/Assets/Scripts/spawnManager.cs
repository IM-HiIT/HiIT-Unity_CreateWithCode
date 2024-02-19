using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour {


    [SerializeField] private GameObject [] animalPrefabs;
    private int animalIndex = 0;
    [SerializeField] private Vector3 spawnPos = new Vector3(0, 0, 20);

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
