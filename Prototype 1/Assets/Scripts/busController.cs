using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class busController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;

    void Start() {
    }
    // Update is called once per frame
    void FixedUpdate() {

        // Move the Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        // Vehicle Out of Bounds
        if (transform.position.z <= -6f) {
            // Set back to start
            transform.position = new Vector3(transform.position.x,transform.position.y,180f);
        }
    }
}