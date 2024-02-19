using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour {
    [SerializeField] private float outOfBound = 10f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        if ((transform.position.z > outOfBound*3) || (transform.position.z < -outOfBound)) {
            Destroy(gameObject);
        }
    }
}
